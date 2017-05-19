using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Web;
using System.Text;


namespace ChatRest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private const string ConnectionString =
            "Server=tcp:periscopechatserver.database.windows.net,1433;Initial Catalog=Periscope;Persist Security Info=False;User ID=Periscope;Password=Chickenpizza123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";



        public static Message ReadMessage(IDataRecord Reader)
        {
            string msg = Reader.GetString(0);
            Message newMessage = new Message
            {
                _Message = msg
            };
            return newMessage;
        }

        public List<Message> GetAllMessages()
        {
            const string SelectMessages = "select Message from ChatTable ";
            List<Message> Messages = new List<Message>();
            using (SqlConnection databaseConnection = new SqlConnection(ConnectionString))
            {
                databaseConnection.Open();
                using (SqlCommand selectCommand = new SqlCommand(SelectMessages, databaseConnection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Message student = ReadMessage(reader);
                                Messages.Add(student);
                            }
                        }
                    }
                }
            }
            return Messages;
        }

        public Message AddMessage(Message newMessage)
        {

            string sqlLine = "insert into ChatTable (Msg) values (@Msg)";

            using (SqlConnection databaseConnection = new SqlConnection(ConnectionString))
            {
                databaseConnection.Open();
                using (SqlCommand AddingCommand = new SqlCommand(sqlLine, databaseConnection))
                {
                    AddingCommand.Parameters.Add(new SqlParameter("Msg", newMessage));
                    AddingCommand.ExecuteNonQuery();
                }
            }


            return newMessage;
        }
    }
}
