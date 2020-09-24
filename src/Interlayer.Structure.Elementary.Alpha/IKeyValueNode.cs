using System.Collections.Generic;

namespace Interlayer.Structure.Elementary.Alpha {
    /// <summary>
    /// <p>
    /// Dictionary-like structure that contains values mapped to keys.
    /// </p>
    ///
    /// <p>
    /// Please note that both keys and values are `INode`s rather then
    /// more specific types, since nothing limits having lists as keys,
    /// for example.
    /// </p>
    /// </summary>
    /// <typeparam name="N"></typeparam>
    public interface IKeyValueNode<N> : INode where N : INode {
        IEnumerable<N> Keys { get; }
        N this[N key] { get; }
    }

    /// <summary>
    /// Simplified interface which is implied to be used only in end
    /// projects, testing and other code without derivative works. Be
    /// aware that should anyone use this interface to build their code
    /// on, <see cref="IKeyValueNode{N}"/> would not be usable, and thus
    /// interoperability, which is sole purpose of this project, would
    /// vanish. 
    /// </summary>
    public interface IKeyValueNode : IKeyValueNode<INode> { }
}
