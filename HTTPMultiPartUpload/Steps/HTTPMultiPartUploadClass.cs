using DecisionsFramework.Design.Flow;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// The simplest types of steps are method based sync steps.  Simply write whatever
/// .NET code you want and use an attribute on the CLASS or on the METHOD itself to 
/// register that code with the workflow engine as a flow step.
/// </summary>
namespace HTTPMultiPartUpload.Steps
{
    [AutoRegisterMethodsOnClass(true, "Integration/HTTP")]
    public class HTTPMultiPartUploadClass
    {
        public string PostHttpMultiPartFile(string URL, string ContentType, string BearerToken, string FileName, string FilePath)
        {

            try
            {
                var client = new RestClient(URL);
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", ContentType);
                request.AddHeader("Authorization", BearerToken);
                request.AddParameter("file_name", FileName);
                request.AddFile("file", "/" + FilePath);
                IRestResponse response = client.Execute(request);
                return response.Content;

            }
            catch (Exception)
            {

                throw;
                
            }
        }

    }
}
