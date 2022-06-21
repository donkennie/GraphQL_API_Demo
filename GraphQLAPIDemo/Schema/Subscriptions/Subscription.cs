using GraphQLAPIDemo.Schema.Mutations;
using GraphQLAPIDemo.Schema.Queries;
using HotChocolate;
using HotChocolate.Execution;
using HotChocolate.Subscriptions;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLAPIDemo.Schema.Subscriptions
{
    public class Subscription
    {
        [Subscribe]
        public CourseResult CourseCreated([EventMessage] CourseResult course) => course;


        [SubscribeAndResolve]
        public ValueTask<ISourceStream <CourseResult>> CourseUpdate(Guid courseId, [Service] ITopicEventReceiver topicEventReceiver)
        {
            string topicName = $"{courseId}_{nameof(Subscription.CourseUpdate)}";

            return topicEventReceiver.SubscribeAsync<string, CourseResult>(topicName);
        }
    }
}
