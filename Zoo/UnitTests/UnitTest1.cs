using System;
using Xunit;
using  Zoo.Class;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        static void HumanInheritsSound()
        {
            Human human = new Human();
            string actual = human.Sound(human.Name);
            string reply = "Human can make sounds";
            Assert.Equal(reply, actual);
        }

        [Fact]
        static void ApeInheritsSound()
        {
            Ape ape = new Ape();
            string actual = ape.Sound(ape.Name);
            string reply = "Ape can make sounds";
            Assert.Equal(reply, actual);
        }

        [Fact]
        static void DolphinInheritsSound ()
        {
            Dolphin dolphin = new Dolphin();
            string actual = dolphin.Sound(dolphin.Name);
            string reply ="Dolphin can make sounds";
            Assert.Equal(reply, actual);
        }

        [Fact]
        static void WhaleitsSound()
        {
            Whale whale = new Whale();
            string actual = whale.Sound(whale.Name);
            string reply = "Whale can make sounds";
            Assert.Equal(reply, actual);
        }

        [Fact]
        static void SeaLionInheritsSound()
        {
            SeaLion seaLion = new SeaLion();
            string actual = seaLion.Sound(seaLion.Name);
            string reply = "Sea Lion can make sounds";
            Assert.Equal(reply, actual);
        }
    }
}
