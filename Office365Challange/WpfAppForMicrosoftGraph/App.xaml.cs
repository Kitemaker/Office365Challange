using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Identity.Client;
namespace WpfAppForMicrosoftGraph
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
       
            //Below is the clientId of your app registration. 
            //You have to replace the below with the Application Id for your app registration
            public static string ClientId = "d35c683e-e9d2-4d5c-b7d8-dcea48042302";

            public static PublicClientApplication PublicClientApp = new PublicClientApplication(ClientId);

        
    }
}
