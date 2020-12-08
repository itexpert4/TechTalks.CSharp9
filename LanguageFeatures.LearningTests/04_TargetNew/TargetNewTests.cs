﻿using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace LanguageFeatures.LearningTests
{
    // public sealed class RiderSettings : IdeSettings
    // {
    //     public RiderSettings() 
    //         : base(WhitespaceCharacter.Space)
    //     {
    //     }
    //
    //     public Dictionary<string, string> AdditionalAttributes = new Dictionary<string, string>();
    //     
    //     public List<FontSettings> SupportedFonts { get; } = new List<FontSettings>();
    // }

    public sealed class TargetNewTests
    {
        /* Initializer
        [Fact]
        public void Should_Infer_Type_For_Property_With_NonAbstract_Type()
        {
            var settings = new RiderSettings();

            settings.SupportedFonts.Should().NotBeNull();
            settings.SupportedFonts.Should().BeOfType<List<FontSettings>>();
        }
        */
        
        /* Ternary
        [Fact]
        public void Should_Infer_Type_For_Ternary_Operator()
        {
            static IdeSettings CreateSettings(bool isCrossPlatform)
                => new VisualStudioSettings();

            var nonCrossPlatformSettings = CreateSettings(false);
            var crossPlatformSettings = CreateSettings(true);

            nonCrossPlatformSettings.Should().BeOfType<VisualStudioSettings>();
            crossPlatformSettings.Should().BeOfType<RiderSettings>();
        }
        */

        /* Arguments
        [Fact]
        public void Should_Infer_Type_For_Arguments()
        {
            static string StartIde(VisualStudioSettings settings)
                => $"Starting with {settings.GetType().Name}";

            StartIde(new()).Should().Be("Starting with RiderSettings");
            StartIde(new() { EditorScaling = 200 }).Should().Be("Starting with RiderSettings");
        }
        */

        /* var
        [Fact]
        public void Is_Reversed_VAR_Alternative()
        {
            VisualStudioSettings visualStudioSettings = new();
            
            List<RiderSettings> listOfRiderSettings = new()
            {
                new(),
                new()
            };

            (RiderSettings RiderSettings, VisualStudioSettings VsSettings) settingsTuple = new();

            visualStudioSettings.Should().NotBeNull();

            listOfRiderSettings.Should()
                .HaveCount(2)
                .And.NotContainNulls();

            settingsTuple.RiderSettings.Should().NotBeNull();
            settingsTuple.VsSettings.Should().NotBeNull();
        }
        */

        /* Throw
        [Fact]
        public void Is_Supported_When_Throwing()
        {
            static void StopIt()
            {
                throw new("Sometimes you just need to take a break...");
            }

            Assert.Throws<Exception>(StopIt);
        }
        */
    }
}