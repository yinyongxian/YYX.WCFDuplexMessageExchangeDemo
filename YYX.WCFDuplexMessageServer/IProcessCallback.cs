using System.ServiceModel;

namespace YYX.WCFDuplexMessageServer
{
    [ServiceContract]
    public interface IProcessCallback
    {
        [OperationContract]
        void TaskProcess(int number);
    }
}