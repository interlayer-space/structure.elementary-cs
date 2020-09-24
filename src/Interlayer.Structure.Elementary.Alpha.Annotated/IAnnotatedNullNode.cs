namespace Interlayer.Structure.Elementary.Alpha.Annotated {
    /// <summary>
    /// See <see cref="INullNode"/> and <see cref="IAnnotatedNode{N}"/>.
    /// </summary>
    public interface IAnnotatedNullNode<N> : INullNode, IAnnotatedNode<N> where N : INode {}
}
