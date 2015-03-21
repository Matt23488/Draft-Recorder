using DraftServiceLayer.Concrete;
using MtgDraftRecorder.Controllers;
using System.Web.Mvc;

namespace MtgDraftRecorder.Infrastructure
{
	public class ControllerFactory : DefaultControllerFactory
	{
		protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, System.Type controllerType)
		{
			if (controllerType == typeof(PlayerController))
			{
				return new PlayerController(new GenericRepository());
			}
			else if(controllerType == typeof(DraftController))
			{
				return new DraftController(new GenericRepository());
			}
			else if(controllerType == typeof(AnnouncementController))
			{
				return new AnnouncementController(new GenericRepository());
			}
			else
			{
				return base.GetControllerInstance(requestContext, controllerType);
			}
		}
	}
}