
using Manos;
using System;

namespace Aqrubik.Web {

	public class AqrubikWebApp : ManosApp {

		public AqrubikWebApp ()
		{
			//Route ("/Content/", new StaticContentModule ());
		}

        [Route("/", "/Home", "/Index")]
        public void Index(IManosContext ctx) {
            ctx.Response.End(@"<html>
                               <head><title>Welcome to Aqrubik</title></head>
                               <body>
                                <form method='POST' action='TestSubmit'>
                                 <input type='text' name='link'>
                                 <input type='submit'>
                                </form>
                               </body>
                              </html>");

        }


        [Post("/TestSubmit")]
        public void TestSubmitLink(IManosContext ctx, string link) {
            var template = new RazorTemplate {
                Model = link
            };
            ctx.Response.End(template.TransformText());
        }

	}
}
