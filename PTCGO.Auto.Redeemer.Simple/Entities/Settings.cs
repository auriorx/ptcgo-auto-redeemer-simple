using System.Collections.Generic;

namespace PTCGO.Auto.Redeemer.Simple.Entities
{
    public static class Settings
    {
        public static List<Resolution> Resolutions = new()
        {
            new Resolution()
            {
                ResolutionName = "2560x1440",
                ClickEvents = new List<ClickEvent>
                {
                    new()
                    {
                        Name = "clickOnCodeBox",
                        Coordinates = (687, 1190),
                    },
                    new()
                    {
                        Name = "clickOnAddCode",
                        Coordinates = (705, 1309),
                    },
                    new()
                    {
                        Name = "clickOnSubmitCodes",
                        Coordinates = (1585, 1308),
                    },
                    new()
                    {
                        Name = "clickOnDuplicateErrorOkButton",
                        Coordinates = (1275, 825),
                    },
                    new()
                    {
                        Name = "clickOnSubmitCodesDoneButton",
                        Coordinates = (1102, 1309),
                    },
                }
            },
            new Resolution()
            {
                ResolutionName = "1920x1200",
                ClickEvents = new List<ClickEvent>
                {
                    new()
                    {
                        Name = "clickOnCodeBox",
                        Coordinates = (485, 981),
                    },
                    new()
                    {
                        Name = "clickOnAddCode",
                        Coordinates = (495, 1081),
                    },
                    new()
                    {
                        Name = "clickOnSubmitCodes",
                        Coordinates = (1211, 1084),
                    },
                    new()
                    {
                        Name = "clickOnDuplicateErrorOkButton",
                        Coordinates = (956, 689),
                    },
                    new()
                    {
                        Name = "clickOnSubmitCodesDoneButton",
                        Coordinates = (814, 1083),
                    },                    
                }
            },
            new Resolution()
            {
                ResolutionName = "1920x1080",
                ClickEvents = new List<ClickEvent>
                {
                    new()
                    {
                        Name = "clickOnCodeBox",
                        Coordinates = (514, 893),
                    },
                    new()
                    {
                        Name = "clickOnAddCode",
                        Coordinates = (527, 980),
                    },
                    new()
                    {
                        Name = "clickOnSubmitCodes",
                        Coordinates = (1191, 982),
                    },
                    new()
                    {
                        Name = "clickOnDuplicateErrorOkButton",
                        Coordinates = (959, 619),
                    },
                    new()
                    {
                        Name = "clickOnSubmitCodesDoneButton",
                        Coordinates = (829, 981),
                    },
                }
            }
        };
    }
}