namespace Interlayer.Structure.Elementary.Alpha {
    /// <summary>
    /// <p>
    /// Common interface for all nodes that enclose particular value.
    /// </p>
    ///
    /// <p>
    /// My bet here that it won't be commonly used.
    /// </p>
    /// </summary>
    /// 
    /// <typeparam name="T">
    /// Type of value that particular scalar node enclosed.
    /// </typeparam>
    public interface IScalarNode<out T> : INode {
        T Value { get; }
    }
}
