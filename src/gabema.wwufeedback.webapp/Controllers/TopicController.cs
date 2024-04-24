using Microsoft.AspNetCore.Mvc;

namespace gabema.wwufeedback.webapp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TopicController : ControllerBase
{
    public TopicController()
    {

    }

    [HttpPost]
    [Route("{topicId}")]
    public ActionResult SubmitVote([FromRoute] int topicId, CancellationToken cancellationToken)
    {
        // TODO: Update database and redirect
        return new RedirectResult("");
    }
}
