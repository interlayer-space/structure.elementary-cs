namespace Interlayer.Structure.Elementary.Alpha.Annotated {
    /// <summary>
    /// See <see cref="IKeyValueNode{N}"/> and <see cref="IAnnotatedNode{N}"/>.
    /// </summary>
    public interface IAnnotatedKeyValueNode<N> : IKeyValueNode<N>, IAnnotatedNode<N> where N : INode {}
}
