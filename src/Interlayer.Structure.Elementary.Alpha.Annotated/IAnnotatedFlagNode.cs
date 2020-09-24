namespace Interlayer.Structure.Elementary.Alpha.Annotated {
    /// <summary>
    /// See <see cref="IFlagNode"/> and <see cref="IAnnotatedNode{N}"/>.
    /// </summary>
    public interface IAnnotatedFlagNode<N> : IFlagNode, IAnnotatedNode<N> where N : INode {}
}
