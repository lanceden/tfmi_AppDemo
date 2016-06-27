namespace tfmi_demo.Controllers
{
    using System.Web.Http.Cors;

    [EnableCors("*", "*", "PUT, POST")]
    public class FeedbackController : BaseController
    {
        public void Post(Model.Feedback feedbackModel)
        {
            Instance.Feedback.Add(feedbackModel);
            Instance.SaveChanges();
        }
    }
}
