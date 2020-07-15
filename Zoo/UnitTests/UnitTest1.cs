using System;
using Xunit;
using  Zoo.Class;

namespace UnitTests
{
    public class UnitTest1
    {
        // Tests for Human
        [Fact]
        static void HumanInheritsSound()
        {
            Human human = new Human();
            string actual = human.Sound(human.Name);
            string reply = "Yasir can make sounds";
            Assert.Equal(reply, actual);
        }

        [Fact]
        static void HumanInheritsTypeOfEater()
        {
            Human human = new Human();
            string actual = human.TypeOfEater();
            string reply = "Yasir am a omnivore , I eat plants and meat";
            Assert.Equal(reply, actual);
        }

        // Tests for Ape
        [Fact]
        static void ApeInheritsSound()
        {
            Ape ape = new Ape();
            string actual = ape.Sound(ape.Name);
            string reply = "King Kong can make sounds";
            Assert.Equal(reply, actual);
        }

        [Fact]
        static void ApeInheritsTypeOfEater()
        {
            Ape ape = new Ape();
            string actual = ape.TypeOfEater();
            string reply = "King Kong am a herbavore , i eat plants and fruits";
            Assert.Equal(reply, actual);
        }

        // Test for Dolphin
        [Fact]
        static void  DolphinInheritsSound()
        {
            Dolphin dolphin = new Dolphin();
            string actual = dolphin.Sound(dolphin.Name);
            string reply = "Skippy the Dolphin can make sounds";
            Assert.Equal(reply, actual);
        }

        [Fact]
        static void DolphinInheritsGivesBirth ()
        {
            Dolphin dolphin = new Dolphin();
            string actual = dolphin.GivesBirth();
            string reply = "Skippy the Dolphin gives birth and does not lay eggs because it is a mammal";
            Assert.Equal(reply, actual);
        }

        // Tests for Whale
        [Fact]
        static void WhaleInheritsGivesBirth()
        {
            Whale whale = new Whale();
            string actual = whale.GivesBirth();
            string reply = "Manny the Whale gives birth and does not lay eggs because it is a mammal";
            Assert.Equal(reply, actual);
        }

        [Fact]
        static void WhaleInheritsPlaysGames()
        {
            Whale whale = new Whale();
            string actual = whale.PlaysGames();
            string reply = "Manny the Whale loves to play games";
            Assert.Equal(reply, actual);
        }

        // Tests for Sea Lion

        [Fact]
        static void SeaLionInheritsBreathes()
        {
            SeaLion seaLion = new SeaLion();
            string actual = seaLion.Breathe();
            string reply = "Wally the Sea Lion breathes using lungs";
            Assert.Equal(reply, actual);
        }

        static void SeaLionInheritsPlaysGames()
        {
            SeaLion seaLion = new SeaLion();
            string actual = seaLion.PlaysGames();
            string reply = "Wally the Sea Lion loves to play games";
            Assert.Equal(reply, actual);
        }

    }
}
