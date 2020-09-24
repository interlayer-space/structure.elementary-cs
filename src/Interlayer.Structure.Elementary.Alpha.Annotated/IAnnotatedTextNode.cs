namespace Interlayer.Structure.Elementary.Alpha.Annotated {
    /// <summary>
    /// See <see cref="ITextNode"/> and <see cref="IAnnotatedNode{N}"/>.
    /// </summary>
    public interface IAnnotatedTextNode<N> : ITextNode, IAnnotatedNode<N> where N : INode {}
}
