using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Collections;

namespace Reassignment {
    /// <summary>
    /// Interaction logic for firstSteps.xaml
    /// </summary>
    public partial class firstSteps : UserControl {

        // Go In / Out | Look At | Examine | Take / Place
        // Check Inventory | Talk To | Listen To | Attack
        // Smell | Go To | Equip

        int txtNo = 1;

        string executableCommand = "mainAdventureView";

        //contextAndContent["offTheTitleScreen"] = gameStart;

        Dictionary<string, Action> general =
            new Dictionary<string, Action>();

        List<string> helpTexts = new List<string>() {
            "What will you do? Remember, all lower-case and no dots or articles. \n[Commands: go in, go out, look at, examine, take, place, check inventory, talk to, listen to," +
            " attack, smell, go to, equip]",
            "Situation:\nThe sun throws it's beams at you. It's snowy outside and the coffeeshop you sit in has a clock indicating it's morning. The tables of the place seem like they've belonged"
            + " to an office once. A couple of exotic carpets lie on the floor and grey shelves cover the walls. Two ladies sit behind the counter chatting and a few men laugh at one of the cafe's"
            + "corners while sipping tea.",

            /*
            you're sitting in a coffeeshop almost blinded by the beams of the sun. It seems to be morning. The little 
             cafe is decorated with a bunch of old shelves, exotic carpets and little junk presumably collected by some hoarder. Everything's either grey or white or something inbetween. A couple
             ladies run the shop and besides you there are two men enjoying tea at one of the corners.
            */
            "kkk",
            "popopopop"

    };

        public firstSteps() {
            InitializeComponent();
            general.Add(executableCommand, mainsetup);
        }

        private void nextPhase(object sender, RoutedEventArgs e) {
            general[executableCommand]();
        }

        void mainsetup() {
            txtNo = 0;
            newText();
            boxForText.SetValue(Canvas.TopProperty, 290.0);
        }

        void newText() {
            descriptionText.Text = helpTexts[txtNo];
        }

        private void situationClick() {
            //
        }
    }
}
