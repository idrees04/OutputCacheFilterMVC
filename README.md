# OutputCacheFilterMVC
RESULT FILTERS IN ASP.NET MVC 5
1.	A Result Filter Operates on The Result That an Action Method Returns.
2.	The OutputCacheAttribute class is one example of a result filter, which is used to mark an action method whose output will be cached.
3.	The OutputCache filter indicates the MVC Framework to cache the output from an action method.
4.	The same content can be reused to service subsequent requests for the same URL.
5.	Caching action output can offer a significant increase in performance, because most of the time-consuming activities required to process a request are avoided.
6.	Following code snippet shows how to use OutpuCashe attribute:
7.	
8.	In this code, the [OutputCache] attribute is added to the index() action method of the Home controller.
9.	You can specify the duration for which the output of the action should be cached by specifying a Duration property with the duration time in seconds.
10.	Location property specifies where the output is to be cached. It takes enum value and can be stored at:
Any (default Value) , Client, Downstream (proxy server), None (no caching), Server, ServerAndClient
