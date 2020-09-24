namespace Interlayer.Structure.Elementary.Alpha {
    /// <summary>
    /// Simple discriminator to expose node kind without messing with
    /// implemented interfaces checks.
    /// </summary>
    public enum NodeKind {
        Null,
        /// <summary>
        /// Used for nodes of simple boolean value.
        /// </summary>
        Flag,
        /// <summary>
        /// Used for all number nodes.
        /// </summary>
        Decimal,
        /// <summary>
        /// String node.
        /// </summary>
        Text,
        /// <summary>
        /// Map / Dictionary / Hash-like node, which contains 0..N
        /// values under corresponding keys.
        /// </summary>
        KeyValue,
        /// <summary>
        /// List of children nodes.
        /// </summary>
        Sequence,
        /// <summary>
        /// This value exists to let code working with node know that it
        /// is a non-standard implementation and probably skip it if
        /// such code doesn't know this particular type. For example,
        /// this may be used to implement common `IMissedNode` pattern
        /// used in libraries traversing data structures.
        /// </summary>
        Special
    }
}
