namespace Interlayer.Structure.Elementary.Alpha {
    /// <summary>
    /// <p>
    /// This interface serves as a common denominator in whole project,
    /// and all other node interfaces, implementations, consumers and
    /// producers provided by this project are expecting to interact
    /// with this interface.
    /// </p>
    /// 
    /// <p>
    /// It is also implied to be used as same common denominator unit
    /// for all code that works with data pattern specified by this
    /// project.
    /// </p>
    /// </summary>
    public interface INode {
        /// <summary>
        /// Explicitly declares node type.
        /// </summary>
        NodeKind Kind { get; }
    }
}
