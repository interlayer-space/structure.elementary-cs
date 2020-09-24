namespace Interlayer.Structure.Elementary.Alpha.Annotated {
    /// <summary>
    /// <p>
    /// This interface add support for values that describe node itself
    /// rather than value or content.
    /// </p>
    ///
    /// <p>
    /// Common use would be for XML attributes, but please try not to
    /// think about particular format. Also, IIRC YAML had similar
    /// comment-like elements too.
    /// </p>
    /// </summary>
    ///
    /// <typeparam name="N">
    /// Node type used in annotations. Please note that it extends
    /// <see cref="INode"/> and not <see cref="IAnnotatedNode{N}"/>,
    /// since annotations shouldn't be recursively annotated.
    /// </typeparam>
    public interface IAnnotatedNode<N> : INode where N : INode {
        IKeyValueNode<N> Annotations { get; }
    }
}
