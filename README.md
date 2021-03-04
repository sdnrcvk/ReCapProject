# :oncoming_automobile: ReCapProject || Araç Kiralama Sistemi 

![enter image description here](https://user-images.githubusercontent.com/58807892/108602401-ca47ad00-73b2-11eb-9f47-a1d5c73cf856.png)

#    :clipboard: Tanıtım

 :round_pushpin: Entities, DataAccess, Business, Core ve ConsoleUI katmanlarından oluşan araç kiralama sistemi projesidir.
   
:round_pushpin: **Car, Brand, Color, CarImage, Customer, Rental**, nesneleri ve onların operasyonlarından oluşmaktadır.
   
:round_pushpin: Kullanıcılar, roller ve yetkilendirme için CORE/Entities/Concrete katmanı içerisinde  **User, OperationClaim, UserOperationClaim** nesnelerini oluşturduk.
   
:round_pushpin: SOLID prensiplerine uyularak ve yeni teknikler ile geliştirilmeye devam etmektedir.

##   :file_folder: Katmanlar
  
  
:books:  **`Entities`**  
&nbsp;&nbsp;&nbsp;📂  `Concrete`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [Brand.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Entities/Concrete/Brand.cs)           
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [Car.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Entities/Concrete/Car.cs)                  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [CarImage.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Entities/Concrete/CarImage.cs)                    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [Color.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Entities/Concrete/Color.cs)                       
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [Customer.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Entities/Concrete/Customer.cs)                  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [Rental.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Entities/Concrete/Rental.cs)                  
&nbsp;&nbsp;&nbsp;&nbsp;📂  `DTOs`              
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [CarDetailDto.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Entities/DTOs/CarDetailDto.cs)            
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [RentalDetailDto.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Entities/DTOs/RentalDetailDto.cs)                      
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [UserForLoginDto.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Entities/DTOs/UserForLoginDto.cs)                         
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [UserForRegisterDto.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Entities/DTOs/UserForRegisterDto.cs)           

:books:  **`DataAccess `**  
&nbsp;&nbsp;&nbsp;📂  `Abstract`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [IBrandDal.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/DataAccess/Abstract/IBrandDal.cs)                               
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [ICarDal.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/DataAccess/Abstract/ICarDal.cs)                               
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [ICarImageDal.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/DataAccess/Abstract/ICarImageDal.cs)         
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [IColorDal.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/DataAccess/Abstract/IColorDal.cs)            
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [ICustomerDal.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/DataAccess/Abstract/ICustomerDal.cs)             
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [IRentalDal.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/DataAccess/Abstract/IRentalDal.cs)           
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [IUserDal.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/DataAccess/Abstract/IUserDal.css)        
&nbsp;&nbsp;&nbsp;📂  `Concrete`              
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂  `EntityFramework`               
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂  `Context`                
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [RentACarContext.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Concrete/EntityFramework/Context/RentACarContext.cs)                    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [EfBrandDal.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/DataAccess/Concrete/EntityFramework/EfBrandDal.cs)                  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [EfCarImageDal.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/DataAccess/Concrete/EntityFramework/EfCarImageDal.cs)                    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [EfCarDal.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/DataAccess/Concrete/EntityFramework/EfCarDal.cs)                    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [EfColorDal.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/DataAccess/Concrete/EntityFramework/EfColorDal.cs)                     
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [EfCustomerDal.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/DataAccess/Concrete/EntityFramework/EfCustomerDal.cs)                       
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [EfRentalDal.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/DataAccess/Concrete/EntityFramework/EfRentalDal.cs)                             
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [EfUserDal.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/DataAccess/Concrete/EntityFramework/EfUserDal.cs)

:books:  **`Core`**  
&nbsp;&nbsp;&nbsp;📂  `Aspect`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂  `Autofac`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂  `Caching`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [CacheAspect.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/Aspects/Autofac/Caching/CacheAspect.cs)                          
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂  `Exception`          
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [ExceptionLogAspect.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/Aspects/Autofac/Exception/ExceptionLogAspect.cs)                               
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [CacheRemoveAspect.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/Aspects/Autofac/Exception/CacheRemoveAspect.cs)                  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂  `Logging`                   
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [LogAspect.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/Aspects/Autofac/Logging/LogAspect.cs)                         
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂  `Performance`                
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [PerformanceAspect.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/Aspects/Autofac/Performance/PerformanceAspect.cs)                    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂  `Transaction`                 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [TransactionScopeAspect.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/Aspects/Autofac/TransactionScopeAspect.cs)                    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂  `Validation`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [ValidationAspect.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/Aspects/Autofac/Validation/ValidationAspect.cs)                  
&nbsp;&nbsp;&nbsp;📂  `CrossCuttingConcerns`                              
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂  `Caching`                   
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂  `Microsoft`                   
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [MemoryCacheManager.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/CrossCuttingConcerns/Caching/Microsoft/MemoryCacheManager.cs)                       
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [ICacheManager.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/CrossCuttingConcerns/Caching/ICacheManager.cs)               
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂  `Logging`                 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂  `Log4Net`                     
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂  `Layouts`                     
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [JsonLayout.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/CrossCuttingConcerns/Logging/Log4Net/Layouts/JsonLayout.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂  `Loggers`                   
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [DatabaseLogger.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/CrossCuttingConcerns/Logging/Log4Net/Loggers/DatabaseLogger.cs)                    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [FileLogger.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/CrossCuttingConcerns/Logging/Log4Net/Loggers/FileLogger.cs)                                 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [LoggerServiceBase.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/CrossCuttingConcerns/Logging/Log4Net/LoggerServiceBase.cs)                       
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [SerializableLogEvent.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/CrossCuttingConcerns/Logging/Log4Net/SerializableLogEvent.cs)                       
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [LogDetail.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/CrossCuttingConcerns/Logging/LogDetail.cs)                     
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [LogDetailWithException.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/CrossCuttingConcerns/Logging/LogDetailWithException.cs)                             
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [LogParameter.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/CrossCuttingConcerns/Logging/LogParameter.cs)                          
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂  `Validation`                   
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [ValidationTool.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/CrossCuttingConcerns/Validation/ValidationTool.cs)                       
&nbsp;&nbsp;&nbsp;📂  `DataAccess`                   
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [IEntityRepository.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/DataAccess/IEntityRepository.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂  `EntityFramework`                  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [EfEntityRepositoryBase.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/DataAccess/EntityFramework/EfEntityRepositoryBase.cs)                          
&nbsp;&nbsp;&nbsp;📂  `DependencyResolvers`                                                  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [CoreModule.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/DependencyResolvers/CoreModule.cs)                                   
&nbsp;&nbsp;&nbsp;📂  `Entities`                             
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂  `Abstract`                                                          
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [IDto.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/Entities/Abstract/IDto.cs)          
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [IEntity.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/Entities/Abstract/IEntity.css)         
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂  `Concrete`                                  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [OperationClaim.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/Entities/Concrete/OperationClaim.cs)                        
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [User.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/Entities/Concrete/User.cs)     
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [UserOperationClaim.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/Entities/Concrete/UserOperationClaim.cs)                                                                                      
&nbsp;&nbsp;&nbsp;📂  `Extensions`                                         
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [ClaimExtensions.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/Extensions/ClaimExtensions.cs)             
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [ClaimPrincipalExtensions.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/Extensions/ClaimsPrincipalExtensions.cs)    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [ErrorDetails.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/Extensions/ErrorDetails.cs)              
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [ExceptionMiddleware.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/Extensions/ExceptionMiddleware.cs)      
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [ExceptionMiddlewareExtensions.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/Extensions/ExceptionMiddlewareExtensions.cs)             
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [ServiceCollectionExtensions.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/Extensions/ServiceCollectionExtensions.cs)                           
&nbsp;&nbsp;&nbsp;📂  `Utilities`                         
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂  `Business`                     
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [BusinessRules.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/Utilities/Business/BusinessRules.cs)                         
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂  `FileHelper`                         
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [FileHelper.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/Utilities/FileHelper/FileHelper.cs)                    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂  `Interceptors`                            
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [AspectInterceptorSelector.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/Utilities/Interceptors/AspectInterceptorSelector.cs)                                  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [MethodInterception.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/Utilities/Interceptors/MethodInterception.cs)                    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [MethodInterceptionBaseAttribute.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/Utilities/Interceptors/MethodInterceptionBaseAttribute.cs)                      
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂  `IoC`                          
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [ServiceTool.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/Utilities/Results/IoC/ServiceTool.cs)      
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [ICoreModule.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/Utilities/Results/IoC/ICoreModule.cs)     
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂  `Messages`                  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [AspectMessages.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/Utilities/Messages/AspectMessages.cs)     
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂  `Results`                                                                          
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂  `Abstract`                                                             
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [IDataResult.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/Utilities/Results/Abstract/IDataResult.cs)                    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [IResult.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/Utilities/Results/Abstract/IResult.cs)                  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂  `Concrete`                                           
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [DataResult.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/Utilities/Results/Concrete/DataResult.cs)                        
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [SuccessDataResult.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/Utilities/Results/Concrete/SuccessDataResult.cs)                         
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [ErrorDataResult.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/Utilities/Results/Concrete/ErrorDataResult.cs)                           
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [Result.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/Utilities/Results/Concrete/Result.cs)                                 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [SuccessResult.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/Utilities/Results/Concrete/SuccessResult.cs)                       
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [ErrorResult.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/Utilities/Results/Concrete/ErrorResult.cs)                               
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂  `Security`                            
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂  `Encryption`                                                       
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [SecurityKeyHelper.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/Utilities/Security/Encryption/SecurityKeyHelper.cs)                               
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [SigningCredentialsHelper.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/Utilities/Security/Encryption/SigningCredentialsHelper.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂  `Hashing`                                                   
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [HashingHelper.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/Utilities/Security/Hashing/HashingHelper.cs)                      
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂  `JWT`                                              
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [AccessToken.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/Utilities/Security/JWT/AccessToken.cs)                                                        
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [ITokenHelper.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/Utilities/Security/JWT/ITokenHelper.cs)                    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [JwtHelper.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/Utilities/Security/JWT/JwtHelper.cs)                                                 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [TokenOptions.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Core/Utilities/Security/JWT/TokenOptions.cs)           
                            
  
:books:  **`Business`**  
&nbsp;&nbsp;&nbsp;📂  `Abstract`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [IAuthService.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Business/Abstract/IAuthService.cs)            
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [IBrandService.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Business/Abstract/IBrandService.cs)            
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [ICarImageService.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Business/Abstract/ICarImageService.cs)            
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [ICarService.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Business/Abstract/ICarService.cs)               
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [IColorService.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Business/Abstract/IColorService.cs)               
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [ICustomerService.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Business/Abstract/ICustomerService.cs)             
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [IRentalService.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Business/Abstract/IRentalService.cs)             
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [IUserService.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Business/Abstract/IUserService.cs)             
📂  `BusinessAspects`                             
&nbsp;&nbsp;&nbsp;📂  `Autofac`                           
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [SecuredOperation.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Business/BusinessAspects/Autofac/SecuredOperation.cs)  
📂  `Concrete`                               
&nbsp;&nbsp;&nbsp;📃  [AuthManager.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Business/Concrete/AuthManager.cs)                       
&nbsp;&nbsp;&nbsp;📃  [BrandManager.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Business/Concrete/BrandManager.cs)                                
&nbsp;&nbsp;&nbsp;📃  [CarImageManager.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Business/Concrete/CarImageManager.cs)               
&nbsp;&nbsp;&nbsp;📃  [CarManager.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Business/Concrete/CarManager.cs)                       
&nbsp;&nbsp;&nbsp;📃  [ColorManager.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Business/Concrete/ColorManager.cs)                      
&nbsp;&nbsp;&nbsp;📃  [CustomerManager.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Business/Concrete/CustomerManager.cs)                    
&nbsp;&nbsp;&nbsp;📃  [RentalManager.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Business/Concrete/RentalManager.cs)                  
&nbsp;&nbsp;&nbsp;📃  [UserManager.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Business/Concrete/UserManager.cs)                    
📂  `Constants`                
&nbsp;&nbsp;&nbsp;📃  [Messages.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Business/Constants/Messages.cs)               
📂  `DependencyResolvers`                    
&nbsp;&nbsp;&nbsp;📂  `Autofac`              
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [AutofacBusinessModule.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Business/DependencyResolvers/Autofac/AutofacBusinessModule.cs)  
📂  `ValidationRules`               
&nbsp;&nbsp;&nbsp;📂  `FluentValidation`                                                       
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [BrandValidator.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Business/ValidationRules/FluentValidation/BrandValidator.cs)                
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [CarImageValidator.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Business/ValidationRules/FluentValidation/CarImageValidator.cs)                 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [CarValidator.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Business/ValidationRules/FluentValidation/CarValidator.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [ColorValidator.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Business/ValidationRules/FluentValidation/ColorValidator.cs)                  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [CustomerValidator.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Business/ValidationRules/FluentValidation/CustomerValidator.cs)                         
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [RentalValidator.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Business/ValidationRules/FluentValidation/RentalValidator.cs)                      
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃  [UserValidator.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/Business/ValidationRules/FluentValidation/UserValidator.cs)

  
:books:  **`ConsolUI`**  
&nbsp;&nbsp;&nbsp;📃  [Program.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/ConsoleUI/Program.cs)

  
:books:  **`WebAPI`**  
&nbsp;&nbsp;&nbsp;📃  [Startup.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/WebAPI/Startup.cs)  
📂  `Controllers`                  
&nbsp;&nbsp;&nbsp;📃  [AuthController.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/WebAPI/Controllers/AuthController.cs)  
&nbsp;&nbsp;&nbsp;📃  [BrandsController.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/WebAPI/Controllers/BrandsController.cs)  
&nbsp;&nbsp;&nbsp;📃  [CarImagesController.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/WebAPI/Controllers/CarImagesController.cs)  
&nbsp;&nbsp;&nbsp;📃  [CarsController.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/WebAPI/Controllers/CarsController.cs)  
&nbsp;&nbsp;&nbsp;📃  [ColorsController.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/WebAPI/Controllers/ColorsController.cs)  
&nbsp;&nbsp;&nbsp;📃  [CustomersController.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/WebAPI/Controllers/CustomersController.cs)  
&nbsp;&nbsp;&nbsp;📃  [RentalsController.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/WebAPI/Controllers/RentalsController.cs)  
&nbsp;&nbsp;&nbsp;📃  [UsersController.cs](https://github.com/sdnrcvk/ReCapProject/blob/main/WebAPI/Controllers/UsersController.cs)

##   :dizzy: Görünüm
![4](https://user-images.githubusercontent.com/58807892/110037697-d424c500-7d4f-11eb-8d9a-8ea4307dc195.jpg)
![1](https://user-images.githubusercontent.com/58807892/110037705-d5ee8880-7d4f-11eb-9b7b-a6be35b78ad3.jpg)
![2](https://user-images.githubusercontent.com/58807892/110037709-d7b84c00-7d4f-11eb-84c0-eb3dfda11ce3.jpg)
![3](https://user-images.githubusercontent.com/58807892/110037715-da1aa600-7d4f-11eb-8bdd-48a821092030.jpg)

