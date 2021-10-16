using System.ServiceModel;

namespace YYX.WCFDuplexMessageServer
{
    public interface IProcessCallback
    {
        [OperationContract]
        void TaskProcess(int number);
    }
}