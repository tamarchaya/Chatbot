
using BasePlugin.Interfaces;
using BasePlugin.Records;
using System;
using System.Collections.Generic;

namespace Area_of_circle
{

        public class Area_of_circlePlugin : IPlugin
        {
            public static string _Id = "Area_of_circle";
            public string Id => _Id;

            public PluginOutput Execute(PluginInput input)
            {
                int radius = 0;
                double Area_of_circle = 0;
                if (input.Message == "")
                {
                    input.Callbacks.StartSession();
                    return new PluginOutput("Area_of_circle Enter radius . Enter 'Exit' to stop.");
                }
                else if (input.Message.ToLower() == "exit")
                {
                    input.Callbacks.EndSession();
                    return new PluginOutput("Area_of_circle stopped.");
                }
                else
                {
                    radius = int.Parse(input.Message);
                    Area_of_circle = radius * radius * 3.14;

                    return new PluginOutput("The Area_of_circle is " + Area_of_circle, Area_of_circle.ToString());
                }
            }
        }
    }
