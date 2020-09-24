namespace Interlayer.Structure.Elementary.Alpha.Annotated {
    /// <summary>
    /// See <see cref="INumericNode"/> and <see cref="IAnnotatedNode{N}"/>.
    /// </summary>
    public interface IAnnotatedNumericNode<N> : INumericNode, IAnnotatedNode<N> where N  : INode {}
}
