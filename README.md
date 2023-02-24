# Com.RusticiSoftware.Cloud.V2 - the C# library for the SCORM Cloud Rest API

REST API used for SCORM Cloud integrations.

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 2.0
- SDK version: 3.0.1
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

## Requirements
Supports the following frameworks:
- .NET Framework 4.6.1 or later
- .NET 5 or later

## Installation
### NuGet
[Com.RusticiSoftware.Cloud.V2](https://www.nuget.org/packages/Com.RusticiSoftware.Cloud.V2/)

### Local
#### Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp)
- [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/)
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/)

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

#### Library
Download the [.NET SDK](https://dotnet.microsoft.com/download) and run the following commands to generate the DLL:
```shell
cd src/Com.RusticiSoftware.Cloud.V2
dotnet restore
dotnet build
```

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;
```

To build a NuGet package, run the following commands (will need to be in the same src/Com.RusticiSoftware.Cloud.V2 directory as before):
```shell
dotnet pack
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

## Tips and Tricks
**Note:** If using a version of .NET Framework < 4.6, then you will need to add `System.Net.ServicePointManager.SecurityProtocol |= System.Net.SecurityProtocolType.Tls12` to your code.
This is because older versions of .NET Framework do not support TLS 1.2 by default, and it is the minimum TLS version we support.

Working with headers will require calling the `WithHttpInfo` version of the function. This allows for grabbing the header directly from the response object:
```csharp
// Note: This code is specifically designed to not modify any existing data
DispatchApi dispatchApi = new DispatchApi();
ApiResponse<object> response = dispatchApi.UpdateDispatchesWithHttpInfo(new UpdateDispatchSchema(), since: DateTime.Now);
Console.WriteLine(response.Headers["X-Total-Count"]);
```

## Changelog:
Check the [changelog](https://cloud.scorm.com/docs/v2/reference/changelog/) for details of what has changed.

## Sample Code
```csharp
using Com.RusticiSoftware.Cloud.V2.Api;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace ScormCloud_Cs_Sample
{
    class ScormCloud_Cs_Sample
    {
        // ScormCloud API credentials
        // Note: These are not the same credentials used to log in to ScormCloud
        const string APP_ID = "APP_ID";
        const string SECRET_KEY = "SECRET_KEY";

        // Sample values for data
        const string COURSE_PATH = "/PATH/TO/COURSE/RunTimeAdvancedCalls_SCORM20043rdEdition.zip";

        const string COURSE_ID = "CS_SAMPLE_COURSE";
        const string LEARNER_ID = "CS_SAMPLE_COURSE_LEARNER";
        const string REGISTRATION_ID = "CS_SAMPLE_COURSE_REGISTRATION";

        // String used for output formatting
        const string OUTPUT_BORDER = "---------------------------------------------------------\n";

        /// <summary>
        /// This sample will consist of:
        /// 1. Creating a course.
        /// 2. Registering a learner for the course.
        /// 3. Building a link for the learner to take the course.
        /// 4. Getting the learner's progress after having taken the course.
        /// 5. Viewing all courses and registrations.
        /// 6. Deleting all of the data created via this sample.
        /// </summary>
        /// <remarks>
        /// All input variables used in this sample are defined up above.
        /// </remarks>
        static void Main(string[] args)
        {
            // Configure HTTP basic authorization: APP_NORMAL
            Configuration.Default.Username = APP_ID;
            Configuration.Default.Password = SECRET_KEY;

            var sc = new ScormCloud_Cs_Sample();

            try
            {
                // Create a course and a registration
                CourseSchema courseDetails = sc.CreateCourse(COURSE_ID, COURSE_PATH);
                sc.CreateRegistration(COURSE_ID, LEARNER_ID, REGISTRATION_ID);

                // Show details of the newly imported course
                Console.WriteLine("Newly Imported Course Details: ");
                Console.WriteLine(courseDetails);



                // Create the registration launch link
                string launchLink = sc.BuildLaunchLink(REGISTRATION_ID);

                // Show the launch link
                Console.WriteLine(OUTPUT_BORDER);
                Console.WriteLine($"Launch Link: {launchLink}");
                Console.WriteLine("Navigate to the url above to take the course. Hit enter once complete.");
                Console.ReadLine();



                // Get the results for the registration
                RegistrationSchema registrationProgress = sc.GetResultForRegistration(REGISTRATION_ID);

                // Show details of the registration progress
                Console.WriteLine(OUTPUT_BORDER);
                Console.WriteLine("Registration Progess: ");
                Console.WriteLine(registrationProgress);



                // Get information about all the courses in ScormCloud
                List<CourseSchema> courseList = sc.GetAllCourses();

                // Show details of the courses
                Console.WriteLine(OUTPUT_BORDER);
                Console.WriteLine("Course List: ");
                foreach (CourseSchema course in courseList)
                {
                    Console.WriteLine(course);
                }



                // Get information about all the registrations in ScormCloud
                List<RegistrationSchema> registrationList = sc.GetAllRegistrations();

                // Show details of the registrations
                Console.WriteLine(OUTPUT_BORDER);
                Console.WriteLine("Registration List: ");
                foreach (RegistrationSchema registration in registrationList)
                {
                    Console.WriteLine(registration);
                }
            }
            catch (Exception e) when (e is ApiException || e is ArgumentException)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                // Delete all the data created by this sample
                sc.CleanUp(COURSE_ID, REGISTRATION_ID);
            }
        }

        /// <summary>
        /// Sets the default OAuth token passed with all calls to the API.
        ///
        /// If a token is created with limited scope (i.e. read:registration),
        /// calls that require a different permission set will error. Either a
        /// new token needs to be generated with the correct scope, or the
        /// default access token can be reset to null. This would cause the
        /// request to be made with basic auth credentials (appId/ secret key)
        /// instead.
        /// </summary>
        /// <param name="scopes">List of permissions for calls made with the token.</param>
        /// <remarks>
        /// Additionally, you could create a new configuration object and set
        /// the token on that object instead of the default access token. This
        /// configuration would then be passed into the Api object:
        ///
        /// var courseApi = new CourseApi
        /// {
        ///     Configuration = new Configuration
        ///     {
        ///         AccessToken = applicationManagementApi.CreateToken(
        ///             new TokenRequestSchema(
        ///                 new PermissionsSchema(
        ///                     new List<string> { "write:course", "read:course" }
        ///                 ),
        ///                 DateTime.Now.AddMinutes(2)
        ///             )
        ///         ).Result
        ///     }
        /// };
        ///
        /// Any calls that would use this CourseApi instance would then have the
        /// write:course and read:course permissions passed automatically, but
        /// other instances would be unaffected and continue to use other means
        /// of authorization.
        /// </remarks>
        private void ConfigureOAuth(List<string> scopes)
        {
            var applicationManagementApi = new ApplicationManagementApi();

            // Set permissions and expiry time of the token
            var expiry = DateTime.Now.AddMinutes(2);
            var permissions = new PermissionsSchema(scopes);

            // Make the request to get the OAuth token
            var tokenRequest = new TokenRequestSchema(permissions, expiry);
            StringResultSchema tokenResult = applicationManagementApi.CreateToken(tokenRequest);

            // Set the default access token used with further API requests.
            // To remove the token, reset Configuration.Default.AccessToken
            // back to null before the next call.
            Configuration.Default.AccessToken = tokenResult.Result;
        }

        /// <summary>
        /// Creates a course by uploading the course from your local machine.
        /// Courses are a package of content for a learner to consume.
        /// </summary>
        /// <param name="courseId">Id that will be used to identify the course.</param>
        /// <param name="coursePath">Path to the course being uploaded.</param>
        /// <remarks>
        /// Other methods for importing a course exist. Check the documentation
        /// for additional ways of importing a course.
        /// </remarks>
        /// <returns>Detailed information about the newly uploaded course.</returns>
        CourseSchema CreateCourse(string courseId, string coursePath)
        {
            // (Optional) Further authenticate via OAuth token access
            // ConfigureOAuth(new List<string> { "write:course", "read:course" });

            // This call will use OAuth with the "write:course" scope
            // if configured.  Otherwise the basic auth credentials will be used
            var courseApi = new CourseApi();
            StringResultSchema jobId = courseApi.CreateUploadAndImportCourseJob(courseId, _file: File.Open(coursePath, FileMode.Open));

            // This call will use OAuth with the "read:course" scope
            // if configured.  Otherwise the basic auth credentials will be used
            ImportJobResultSchema jobResult = courseApi.GetImportJobStatus(jobId.Result);
            while (jobResult.Status == ImportJobResultSchema.StatusEnum.RUNNING)
            {
                Thread.Sleep(1000);
                jobResult = courseApi.GetImportJobStatus(jobId.Result);
            }

            if (jobResult.Status == ImportJobResultSchema.StatusEnum.ERROR)
                throw new ArgumentException("Course is not properly formatted: " + jobResult.Message);

            return jobResult.ImportResult.Course;
        }

        /// <summary>
        /// Creates a registration allowing the learner to consume the course
        /// content. A registration is the link between a learner and a single
        /// course.
        /// </summary>
        /// <param name="courseId">Id of the course to register the learner for.</param>
        /// <param name="learnerId">Id that will be used to identify the learner.</param>
        /// <param name="registrationId">Id that will be used to identify the registration.</param>
        void CreateRegistration(string courseId, string learnerId, string registrationId)
        {
            // (Optional) Further authenticate via OAuth token access
            // ConfigureOAuth(new List<string> { "write:registration" });

            var registrationApi = new RegistrationApi();
            var learner = new LearnerSchema(learnerId);
            var registration = new CreateRegistrationSchema(courseId, learner, registrationId);
            registrationApi.CreateRegistration(registration);
        }

        /// <summary>
        /// Builds a url allowing the learner to access the course.
        /// </summary>
        /// <param name="registrationId">Id of the registration the link is being built for.</param>
        /// <remarks>
        /// This sample will build the launch link and print it out. It will then
        /// pause and wait for user input, allowing you to navigate to the course
        /// to generate sample learner progress. Once this step has been reached,
        /// hitting the enter key will continue program execution.
        /// </remarks>
        /// <returns>Link for the learner to launch the course.</returns>
        string BuildLaunchLink(string registrationId)
        {
            // (Optional) Further authenticate via OAuth token access
            // ConfigureOAuth(new List<string> { "read:registration" });

            var registrationApi = new RegistrationApi();
            var settings = new LaunchLinkRequestSchema(redirectOnExitUrl: "Message");
            LaunchLinkSchema launchLink = registrationApi.BuildRegistrationLaunchLink(registrationId, settings);

            return launchLink.LaunchLink;
        }

        /// <summary>
        /// Gets information about the progress of the registration.
        /// </summary>
        /// <param name="registrationId">Id of the registration to get results for.</param>
        /// <remarks>
        /// For the most up-to-date results, you should implement our postback
        /// mechanism. The basic premise is that any update to the registration
        /// would cause us to send the updated results to your system.
        ///
        /// More details can be found in the documentation:
        /// https://cloud.scorm.com/docs/v2/guides/postback/
        /// </remarks>
        /// <returns>Detailed information about the registration's progress.</returns>
        RegistrationSchema GetResultForRegistration(string registrationId)
        {
            // (Optional) Further authenticate via OAuth token access
            // ConfigureOAuth(new List<string> { "read:registration" });

            var registrationApi = new RegistrationApi();
            RegistrationSchema progress = registrationApi.GetRegistrationProgress(registrationId);

            return progress;
        }

        /// <summary>
        /// Gets information about all courses. The result received from the API
        /// call is a paginated list, meaning that additional calls are required
        /// to retrieve all the information from the API. This has already been
        /// accounted for in the sample.
        /// </summary>
        /// <returns>List of detailed information about all of the courses.</returns>
        List<CourseSchema> GetAllCourses()
        {
            // (Optional) Further authenticate via OAuth token access
            // ConfigureOAuth(new List<string> { "read:course" });

            // Additional filters can be provided to this call to get a subset
            // of all courses.
            var courseApi = new CourseApi();
            CourseListSchema response = courseApi.GetCourses();

            // This call is paginated, with a token provided if more results exist
            List<CourseSchema> courseList = response.Courses;
            while (response.More != null)
            {
                response = courseApi.GetCourses(more: response.More);
                courseList.AddRange(response.Courses);
            }

            return courseList;
        }

        /// <summary>
        /// Gets information about the registration progress for all
        /// registrations. The result received from the API call is a paginated
        /// list, meaning that additional calls are required to retrieve all the
        /// information from the API. This has already been accounted for in the
        /// sample.
        /// </summary>
        /// <remarks>
        /// This call can be quite time-consuming and tedious with lots of
        /// registrations. If you find yourself making lots of calls to this
        /// endpoint, it might be worthwhile to look into registration postbacks.
        ///
        /// More details can be found in the documentation:
        /// https://cloud.scorm.com/docs/v2/guides/postback/
        /// </remarks>
        /// <returns>List of detailed information about all of the registrations.</returns>
        List<RegistrationSchema> GetAllRegistrations()
        {
            // (Optional) Further authenticate via OAuth token access
            // ConfigureOAuth(new List<string> { "read:registration" });

            // Additional filters can be provided to this call to get a subset
            // of all registrations.
            var registrationApi = new RegistrationApi();
            RegistrationListSchema response = registrationApi.GetRegistrations();

            // This call is paginated, with a token provided if more results exist
            List<RegistrationSchema> registrationList = response.Registrations;
            while (response.More != null)
            {
                response = registrationApi.GetRegistrations(more: response.More);
                registrationList.AddRange(response.Registrations);
            }

            return registrationList;
        }

        /// <summary>
        /// Deletes all of the data generated by this sample.
        /// </summary>
        /// <param name="courseId">Id of the course to delete.</param>
        /// <param name="registrationId">Id of the registration to delete.</param>
        /// <remarks>
        /// This code is run even if the program has errored out, providing a
        /// "clean slate" for every run of this sample.
        ///
        /// It is not necessary to delete registrations if the course
        /// they belong to has been deleted. Deleting the course will
        /// automatically queue deletion of all registrations associated with
        /// the course. There will be a delay between when the course is deleted
        /// and when the registrations for the course have been removed. The
        /// registration deletion has been handled here to prevent scenarios
        /// where the registration hasn't been deleted yet by the time the
        /// sample has been rerun.
        /// </remarks>
        void CleanUp(string courseId, string registrationId)
        {
            // (Optional) Further authenticate via OAuth token access
            // ConfigureOAuth(new List<string> { "delete:course", "delete:registration" });

            // This call will use OAuth with the "delete:course" scope
            // if configured.  Otherwise the basic auth credentials will be used
            CourseApi courseApi = new CourseApi();
            courseApi.DeleteCourse(courseId);

            // The code below is to prevent race conditions if the
            // sample is run in quick successions.

            // This call will use OAuth2 with the "delete:registration" scope
            // if configured.  Otherwise the basic auth credentials will be used.
            RegistrationApi registrationApi = new RegistrationApi();
            registrationApi.DeleteRegistration(registrationId);
        }
    }
}

```
