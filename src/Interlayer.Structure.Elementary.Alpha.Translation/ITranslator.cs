namespace Interlayer.Structure.Elementary.Alpha.Translation {
    /// <summary>
    /// Simple adapter that would allow to plug in particular
    /// implementation without knowing any details.
    /// </summary>
    /// 
    /// <typeparam name="N">
    /// Implementation's counterpart for <see cref="INode"/> 
    /// </typeparam>
    /// <typeparam name="T">
    /// Particular derivative type that may be used, if needed.
    /// </typeparam>
    public interface ITranslator<N, T> where T : INode {
        T Decode(N node);
        N Encode(T node);
    }

    /// <summary>
    /// <p>
    /// Simple adapter that would allow to plug in particular
    /// implementation.
    /// </p>
    ///
    /// <p>
    /// It is implied to be used only in end projects, testing and other
    /// code without derivative works. Be aware that should anyone use
    /// this interface to build their code on,
    /// <see cref="ITranslator{N, T}"/> would not be usable, and thus
    /// interoperability, which is sole purpose of this project, would
    /// vanish.
    /// </p> 
    /// </summary>
    /// 
    /// <typeparam name="N">
    /// </typeparam>
    public interface ITranslator<N> : ITranslator<N, INode> { }
}
