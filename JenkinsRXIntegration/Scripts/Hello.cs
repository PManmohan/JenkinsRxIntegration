/*
 * Created by Ranorex
 * User: Mohan
 * Date: 11/20/2023
 * Time: 8:13 AM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using Ranorex;
using Ranorex.Core.Testing;

namespace JenkinsRXIntegration
{
    /// <summary>
    /// Description of Hello.
    /// </summary>
    [TestModule("6037FF58-C6CD-4C13-819E-6DA31F026465", ModuleType.UserCode, 1)]
    public class Hello : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Hello()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
        	Report.Log(ReportLevel.Success,"Hello!");
        }
    }
}
