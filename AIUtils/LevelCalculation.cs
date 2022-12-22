using System;

namespace AIUtils {

    class LevelCalculation {
        
        public static Level calculateLevel(Level level) {
            Level calculatedLevel = null;

            // todo calculate the new coordinates for each 
            switch(level.name) {
                case "SCI_HOSPITALUPPER":
                    calculatedLevel = calculateSciHospitalUpper(level);
                    break;

                case "TECH_COMMS":
                case "TECH_HUB":
                case "-":
                case "":
                default:
                    calculatedLevel = level;
                    break;
            }

            return calculatedLevel;
        }

        private static Level calculateSciHospitalUpper(Level level) {
            Level calculatedLevel = new Level();

            calculatedLevel.name = level.name;
            calculatedLevel.x = level.z + 107;
            calculatedLevel.y = level.y;
            calculatedLevel.z = (-1 * level.x) + 16;

            return calculatedLevel;
        }
    }
}
