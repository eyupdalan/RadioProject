using System;
using System.Globalization;
using System.ServiceModel;

namespace RadyoCommon
{
    public abstract class ServiceBase
    {
        protected delegate void ParameterlessMethod();

        protected void RunInTryCatch(ParameterlessMethod action)
        {
            try
            {
                action();
            }
            catch(Exception ex)
            {
                throw new FaultException<ServiceFault>(
                        new ServiceFault { ErrorMessage = ex.Message, Source = ex.Source, Target = ex.TargetSite.ToString(), StackTrace = ex.StackTrace },
                        new FaultReason(string.Format(CultureInfo.InvariantCulture, "{0}", "Service Fault Exception : " + ex.Message))
                    );
            }
        }

    }
}
