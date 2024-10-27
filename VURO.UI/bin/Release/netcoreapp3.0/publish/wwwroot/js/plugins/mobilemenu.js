jQuery(document).ready(function( $ ) {
            $("#menu").mmenu({
               "extensions": [
                  "pagedim-black",
                  "theme-white",
                  "effect-menu-slide",
                  "effect-listitems-slide",
                  "shadow-page",
            
               ],
               "offCanvas": {
                  zposition   : "front",
                  position    : "right"
               },
               "counters": true,
               "navbars": [
                  {
                     "position": "top",
					   "content": [
                       '<img src="/images/logo.png" class="img-responsive" alt="Image">'
                     ]
                  },
                  {
                     "position": "top"
				   }
				   ,
                  {
                     "position": "bottom",
                     "content": [
                        
                     ]
                  }
               ]
            });
         });