using System;

namespace AIUtils {

    class LevelCalculation {
        
        public static Level calculateLevel(Level level) {
            Level calculatedLevel = null;

            switch(level.name) {
                case "ENG_REACTOR_CORE (PT1)":
                    calculatedLevel = calculateEngReactorCorePt1(level);
                    break;
                case "HAB_AIRPORT (M17)":
                    calculatedLevel = calculateHabAirportM1(level);
                    break;

                case "HAB_CORPORATEPENT":
                    calculatedLevel = calculateHabCorporatepent(level);
                    break;

                case "SCI_HOSPITALUPPER":
                    calculatedLevel = calculateSciHospitalUpper(level);
                    break;

                // List of levels without offsets
                // These levels will not be shown in the select field
                case "BSP_LV426_PT01":
                case "BSP_LV426_PT02":
                case "BSP_TORRENS":
                case "ENG_TOWPLATFORM":
                case "HAB_SHOPPINGCENTRE":
                case "SCI_ANDROIDLAB":
                case "SCI_HOSPITALLOWER":
                case "SCI_HUB":
                case "SOLACE":
                case "TECH_COMMS":
                case "TECH_HUB":
                case "TECH_MUTHRCORE":
                case "TECH_RND":
                case "TECH_RND_HZDLAB":
                case "-":
                case "":
                default:
                    calculatedLevel = level;
                    break;
            }

            return calculatedLevel;
        }

        private static Level calculateEngReactorCorePt1(Level level) {
            Level calculatedLevel = new Level();

            calculatedLevel.name = level.name;
            calculatedLevel.x = level.x;
            calculatedLevel.y = level.y + 1.9183100f;
            calculatedLevel.z = level.z;

            return calculatedLevel;
        }

        private static Level calculateSciHospitalUpper(Level level) {
            Level calculatedLevel = new Level();

            calculatedLevel.name = level.name;
            calculatedLevel.x = level.z + -107.1510000f;
            calculatedLevel.y = level.y + 0.0000041f;
            calculatedLevel.z = (-1 * level.x) + 15.9814000f;

            return calculatedLevel;
        }

        private static Level calculateHabAirportM1(Level level) {
            Level calculatedLevel = new Level();

            calculatedLevel.name = level.name;
            calculatedLevel.x = level.x + 22.5322000f;
            calculatedLevel.y = level.y + 17.8760000f;
            calculatedLevel.z = level.z + -61.5897000f;

            return calculatedLevel;
        }

        private static Level calculateHabCorporatepent(Level level) {
            Level calculatedLevel = new Level();

            calculatedLevel.name = level.name;
            calculatedLevel.x = level.x - 0.0000529f;
            calculatedLevel.y = level.y;
            calculatedLevel.z = level.z;

            return calculatedLevel;
        }
    }
}
