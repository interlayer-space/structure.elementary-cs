using System.Collections.Generic;

namespace Interlayer.Structure.Elementary.Alpha {
    /// <summary>
    /// An ordered collection of other nodes.
    /// </summary>
    /// 
    /// <typeparam name="N">
    /// Particular node type to use.
    /// </typeparam>
    public interface ISequenceNode<N> : INode where N : INode {
        IEnumerable<N> Content { get; }
        
        long Size { get; }
    }

    /// <summary>
    /// Simplified interface which is implied to be used only in end
    /// projects, testing and other code without derivative works. Be
    /// aware that should anyone use this interface to build their code
    /// on, <see cref="ISequenceNode{N}"/> would not be usable, and thus
    /// interoperability, which is sole purpose of this project, would
    /// vanish.
    /// </summary>
    public interface ISequenceNode : ISequenceNode<INode> {}
}
