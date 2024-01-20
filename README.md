# WeatherDependencyInjection
# Developed by Garth Burrill


## Sample application to demonstrate dependency injection and polymorphism.  

The main Model CityWeather is never referenced in the Solution except for the data layer.  The Model is built in the datalayer and rest of the solution uses the interface ICityWeather to reference the Model.  
