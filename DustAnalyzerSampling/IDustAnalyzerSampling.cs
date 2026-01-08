using ProtocolInterface;

namespace DustAnalyzerSampling
{
    public interface IDustAnalyzerSampling : IProtocol
    {
        Task<Dictionary<string, string>?> Read(string addr, int tryCount = 0, CancellationToken cancelToken = default);
    }
}
