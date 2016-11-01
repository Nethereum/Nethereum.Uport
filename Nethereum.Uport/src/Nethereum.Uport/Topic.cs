using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nethereum.Uport
{
    public class Topic
    {
        public string Url { get; private set; }
        public string Name { get; private set; }

        public string Id { get; private set; }

        public static Topic NewTopic(string serverUrl, string topicName)
        {
            var topic = new Topic()
            {
                Name = topicName,
                Id = KeyGenerator.GetUniqueKey(),
                Url = serverUrl
            };

            if (topicName == "address")
            {
                // address url differs from topic
                topic.Url += "addr/" + topic.Id;
            }
            else
            {
                topic.Url += topicName + '/' + topic.Id;
            }

            return topic;
        }
    }

}
