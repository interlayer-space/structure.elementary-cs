# Interlayer / Structure.Elementary / C#

This project contains interfaces to provide interoperability between 
different libraries that use simple data concept - everything may 
consist of nulls, booleans, numbers, strings, sequences and dictionary
structures.

## Rationale

This project serves three goals:

- Provide a way to convert output of different serializers and 
deserializers into common API. This would allow both seamless 
serializer / deserializer plugging, as well as ability to do mapping
into another format without much hassle and creating entities that serve
no purpose except this mapping.
- Provide a *layer between serializers and mappers*. Most serialization
libraries do both - they not only encode and decode data in some 
arbitrary format, but also reconstruct objects and structures of 
specified type. They should not do both, instead, it would be enough
to have just one mapper for all possible formats and number of 
serializers, so end user would not care about having ton of attributes 
and/or slightly different types for different serializers.
- Provide a unified interface for working with unstructured data. It's 
not always possible to use concrete type for data, but that doesn't mean
there would be no operations taken over it. For example, structure 
passed to program is intended to be processed with JSONPatch operations,
or a special gateway may replace patterns `SCP-\d+` with 
`████-███-██████`.

This project is not targeting to be compatible with every serialization,
deserialization or mapping case. As for now, this project also doesn't
put performance as top priority, thus it prefers to provide interfaces
for complete data structures rather than primitives for async code or
some other functionality which certainly isn't used in majority of
applications. This may be addressed in future, but original goal will
always be a priority.

## Overview

Currently, this project occupies `Interlayer.Structure.Elementary.Alpha`
namespace. During it's maturity it is expected to change to 
`Interlayer.Structure.Elementary.Beta` when API comes somewhere close to 
it's final form and just `Interlayer.Structure.Elementary` when it is 
considered fully stable.

As stated in beginning of this document, it is implied that six types 
are enough for basic data interpretation. Those types are:

- null (INullNode)
- boolean (IFlagNode)
- decimal (INumericNode)
- string (ITextNode)
- array (ISequenceNode)
- dictionary (IKeyValueNode)

All of them inherit from root interface `INode`, which is expected to be
the only type most dependent APIs will accept (e.g. any code that 
translates such structure into instance of some type will accept `INode`
and do internal branching by inspecting passed node).

`INode` requires to implement only one property: `NodeKind Kind { get; }`
(which is called kind just to dismiss ambiguity with language types).
NodeKind itself is just an enum which contains identifiers for six types 
mentioned above and a special `Special` kind, which is created to allow
developers indicate that their implementation requires non-standard
processing and libraries not aware of it would know about that.

There are two auxiliary assemblies, named `Annotated` and `Translation`,
which also can serve as points of interoperability.

### Interlayer.Structure.Elementary.Alpha.Annotated

`Annotated` adds support for node *annotations*, a key-value structure 
that may be used to describe node itself rather than it's value or 
enclosed nodes. This was added to support serialization formats with 
such additional data and named so to both resolve ambiguity with 
language attributes and particular implementation (XML).

Each node type in basic namespace has a corresponding 
`IAnnotated...Node` extending interface for use, so all annotated nodes 
should be treated without problems by libraries that are aware only of
basic set of `INode`s (this, however, may cause context loss for such 
libraries).

In future this term (`Annotated`) may be changed, since many languages 
have an annotation type.

### Interlayer.Structure.Elementary.Alpha.Translation

This assembly exposes interfaces that may be interesting for particular
interoperability adapters implementation. It targets to standardize
utilities that can be used to convert output of particular library X to
`INode`s and vice versa. 

## Weird naming

It may look like this project is targeting specifically JSON, but it
tries to be agnostic in terms of concrete usage, and in fact JSON has 
more limited support for numbers (since this project uses `decimal` 
instead of `double`). Because of that basic symbol names were chosen to 
minimize resemblance to specific technologies.

## Extending

This whole project contains interfaces and enums only, thus developers
may use any implementations they want, building any additional 
functionality. All processing interfaces usually allow to specify
custom type derived from `INode` and such, so it should be possible to
create a facility that not only accepts `ICoolNode` derived from 
`INode`, but also returns the same `ICoolNode` type. Such interfaces are
usually followed by a non-generic sibling, e.g.

```c#
interface Sanitizer<N> where N : INode {
    N Sanitize(N node);
}

interface Sanitizer : Sanitizer<INode> {}
```

Those, however, should be used with caution, since if any library would 
depend on parameterless `Sanitizer`, it won't accept `Sanitizer<N>`, so
those non-generic interfaces are created only to simplify development of 
**end products**, not intermediate libraries.

## Licensing

We believe in code that everyone may use and afterwork nights spent on 
building things without asking anything back.

[UPL-1.0](LICENSE-UPL-1.0) & [MIT](LICENSE-MIT), use whatever suits you 
best.
