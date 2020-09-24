namespace Interlayer.Structure.Elementary.Alpha.Annotated {
    /// <summary>
    /// See <see cref="ISequenceNode{N}"/> and <see cref="IAnnotatedNode{N}"/>.
    /// </summary>
    public interface IAnnotatedSequenceNode<N> : ISequenceNode<N>, IAnnotatedNode<N> where N : INode {}
}
