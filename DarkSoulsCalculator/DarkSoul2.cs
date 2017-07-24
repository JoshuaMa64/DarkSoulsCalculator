using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DarkSoulsCalculator
{
    class DarkSoul2
    {
        // 灵魂记忆与层数之间的相互转化

        #region ConverterOfSmAndLevl

        public static int SmToLevel(int soulMemory)
        {
            var level = 0;
            if (soulMemory < 50000)
            {
                level = soulMemory / 10000 + 1;
            }
            else if (soulMemory < 150000)
            {
                level = (soulMemory - 50000) / 20000 + 6;
            }
            else if (soulMemory < 300000)
            {
                level = (soulMemory - 150000) / 30000 + 11;
            }
            else if (soulMemory < 500000)
            {
                level = (soulMemory - 300000) / 50000 + 16;
            }
            else if (soulMemory < 1500000)
            {
                level = (soulMemory - 500000) / 100000 + 20;
            }
            else if (soulMemory < 3000000)
            {
                level = (soulMemory - 1500000) / 250000 + 30;
            }
            else if (soulMemory < 9000000)
            {
                level = (soulMemory - 3000000) / 2000000 + 36;
            }
            else if (soulMemory < 15000000)
            {
                level = (soulMemory - 9000000) / 3000000 + 39;
            }
            else if (soulMemory < 20000000)
            {
                level = (soulMemory - 15000000) / 5000000 + 41;
            }
            else if (soulMemory < 30000000)
            {
                level = (soulMemory - 20000000) / 10000000 + 42;
            }
            else if (soulMemory < 45000000)
            {
                level = (soulMemory - 30000000) / 15000000 + 43;
            }
            else if (soulMemory >= 45000000)
            {
                level = 44;
            }
            return level;
        }

        public static int[] LevelToSm(int level)
        {
            var soulMemory = new int[2];
            if (level < 6)
            {
                soulMemory[0] = (level - 1) * 10000;
                soulMemory[1] = level * 10000 - 1;
            }
            else if (level < 11)
            {
                soulMemory[0] = (level - 6) * 20000 + 50000;
                soulMemory[1] = (level - 5) * 20000 + 50000 - 1;
            }
            else if (level < 16)
            {
                soulMemory[0] = (level - 11) * 30000 + 150000;
                soulMemory[1] = (level - 10) * 30000 + 150000 - 1;
            }
            else if (level < 20)
            {
                soulMemory[0] = (level - 16) * 50000 + 300000;
                soulMemory[1] = (level - 15) * 50000 + 300000 - 1;
            }
            else if (level < 30)
            {
                soulMemory[0] = (level - 20) * 100000 + 500000;
                soulMemory[1] = (level - 19) * 100000 + 500000 - 1;
            }
            else if (level < 36)
            {
                soulMemory[0] = (level - 30) * 250000 + 1500000;
                soulMemory[1] = (level - 29) * 250000 + 1500000 - 1;
            }
            else if (level < 39)
            {
                soulMemory[0] = (level - 36) * 2000000 + 3000000;
                soulMemory[1] = (level - 35) * 2000000 + 3000000 - 1;
            }
            else if (level < 41)
            {
                soulMemory[0] = (level - 39) * 3000000 + 9000000;
                soulMemory[1] = (level - 38) * 3000000 + 9000000 - 1;
            }
            else if (level == 41)
            {
                soulMemory[0] = 15000000;
                soulMemory[1] = 19999999;
            }
            else if (level == 42)
            {
                soulMemory[0] = 20000000;
                soulMemory[1] = 29999999;
            }
            else if (level == 43)
            {
                soulMemory[0] = 30000000;
                soulMemory[1] = 44999999;
            }
            else if (level == 44)
            {
                soulMemory[0] = 45000000;
                soulMemory[1] = 999999999;
            }
            return soulMemory;
        }


        #endregion

        public static int[] WhiteSignSoapstone(int level)
        {
            var levelRange = new[]{level,level};

            if (level >= 43)
            {
                levelRange[1] = 44;
            }
            else
            {
                levelRange[1] += 1;
            }

            if (level < 4)
            {
                levelRange[0] = 1;
            }
            else
            {
                levelRange[0] -= 3;
            }

            return levelRange;
        }

        public static int[] WhiteSignSoapstoneWithName(int level)
        {
            var levelRange = new[] { level, level };

            if (level >= 40)
            {
                levelRange[1] = 44;
            }
            else
            {
                levelRange[1] += 4;
            }

            if (level < 7)
            {
                levelRange[0] = 1;
            }
            else
            {
                levelRange[0] -= 6;
            }

            return levelRange;
        }

        public static int[] SmallWhiteSignSoapstone(int level)
        {
            var levelRange = new[] { level, level };

            if (level >= 42)
            {
                levelRange[1] = 44;
            }
            else
            {
                levelRange[1] += 2;
            }

            if (level < 5)
            {
                levelRange[0] = 1;
            }
            else
            {
                levelRange[0] -= 4;
            }

            return levelRange;
        }

        public static int[] SmallWhiteSignSoapstoneWithName(int level)
        {
            var levelRange = new[] { level, level };

            if (level >= 39)
            {
                levelRange[1] = 44;
            }
            else
            {
                levelRange[1] += 5;
            }

            if (level < 8)
            {
                levelRange[0] = 1;
            }
            else
            {
                levelRange[0] -= 7;
            }

            return levelRange;
        }

        public static int[] RedSignSoapstone(int level)
        {
            var levelRange = new[] { level, level };

            if (level >= 41)
            {
                levelRange[1] = 44;
            }
            else
            {
                levelRange[1] += 3;
            }

            if (level < 6)
            {
                levelRange[0] = 1;
            }
            else
            {
                levelRange[0] -= 5;
            }

            return levelRange;
        }

        public static int[] RedEyeOrb(int level)
        {
            var levelRange = new[] { level, level };

            if (level >= 40)
            {
                levelRange[1] = 44;
            }
            else
            {
                levelRange[1] += 4;
            }

            return levelRange;
        }

        public static int[] BlueEyeOrb(int level)
        {
            var levelRange = new[] { level, level };

            if (level >= 41)
            {
                levelRange[1] = 44;
            }
            else
            {
                levelRange[1] += 3;
            }

            if (level < 4)
            {
                levelRange[0] = 1;
            }
            else
            {
                levelRange[0] -= 3;
            }

            return levelRange;
        }

        public static int[] Clangorours(int level)
        {
            var levelRange = new[] { level, level };

            if (level >= 41)
            {
                levelRange[1] = 44;
            }
            else
            {
                levelRange[1] += 3;
            }

            if (level > 1)
                levelRange[0]--;
            return levelRange;
        }

        public static int[] Grawing(int level)
        {
            var levelRange = new[] { level, level };

            if (level >= 41)
            {
                levelRange[1] = 44;
            }
            else
            {
                levelRange[1] += 3;
            }

            if (level > 1)
                levelRange[0]--;

            return levelRange;
        }

        public static int[] DragonEye(int level)
        {
            var levelRange = new[] { level, level };

            if (level >= 39)
            {
                levelRange[1] = 44;
            }
            else
            {
                levelRange[1] += 3;
            }

            if (level < 6)
            {
                levelRange[0] = 1;
            }
            else
            {
                levelRange[0] -= 5;
            }

            return levelRange;
        }

        public static int[] Protector(int level)
        {
            var levelRange = new[] { level, level };

            if (level >= 40)
            {
                levelRange[1] = 44;
            }
            else
            {
                levelRange[1] += 4;
            }

            if (level < 6)
            {
                levelRange[0] = 1;
            }
            else
            {
                levelRange[0] -= 5;
            }

            return levelRange;
        }

    }
}
