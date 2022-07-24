using _02.Composite.Models;

namespace _02.Composite.Contracts
{
    public interface IGiftOperations
    {
        void Add(GiftBox gift);
        void Remoce(GiftBox gift);
    }
}
