# Project 4: VR/AR for Social Good!
## Isha Kanu and Esther Putman
### ATLS-CSCI 5616-001
### December 11, 2021
#### Unity Version: 2019.4.33f1

#### Project Title: AR CPR Guide

#### Project Theme Description
Our idea is that many people are nervous to perform CPR, even if they are trained, because they fear they don't fully know the instructions. A mixed reality display like HoloLens could be kept as a part of AED devices to guide civilians through performing CPR in emergency scenarios. We plan to develop an AR environment that displays the Red Cross CPR instructions including scene safety, calling 911, checking the airway, and performing compressions. The pace for compressions could be provided as an audio or visual aid. We have access to a HoloLens we plan to use for demonstration. We would develop this environment in Unity using Microsoft's Mixed Reality Toolkit (MRTK). 

In order to complete the assignment, we will need to learn how to create an AR CPR guide within Unity while using the MRTK package and then connect the guide to the HoloLens. Due to the time constraints of the project, we will have to simulate a CPR mechanical dummy in real life instead of generating one in the AR environment. 

  Instructions for CPR
    Sourced from the [American Red Cross](https://www.redcross.org/take-a-class/cpr/performing-cpr/cpr-steps)

    1. **Scene Safety** : Check the scene and the person. Make sure the scene is safe, then tap the person on the shoulder and shout "Are you OK?" to ensure that        person needs help.
    2. **Call 911** : If that person needs help, you (or a bystander) should call 911. 
    3. **Open the Airway** : With the persson lying on their back, tilt thir head back slightly to lift the chin.
    4. **Check for breathing** : Listen carefully, for no more than 10 seconds, for sounds of breating. (Occasional gasping sounds do not equate to breathing. If        there is no breathing, begin CPR.
    5. **Start compressions**. Push hard, push fast. Place your hands, one on top of the other, in the middle of the chest. USe your body weight to help you            administer compressions that are at atleast 2 inches deep and delivered at a rate of atleast 100 beats per minute.
    6. Continue CPR steps. Keep performing cycles fo chest compressions and breathing until the person exhibits signs of life, such as breathing, or when EMS or        a trained medical responder arrives on the scene.


#### Theme and Storyboard Development
When we decided to create an AR application to assist in performing CPR, we immediately thought about creating a CPR guide. We wanted the guide to be used when a person was in a situation invoking the use of CPR. We imagined that the person would already be CPR certified, so they would be using this guide as a way to be reminded of steps in case they were a bit nervous or apprehensive. As a result, the interface was designed to be super simplistic and easy to go through so that time is spent focused on the situation. The slides were developed in Figma (link below). We also thought that it would be nice to add some sort of simulation of the torso and/or human hands within the AR environment so that the user could gauge where to place their hands on a human body and the correct pacing of the compressions. We wanted to tie in sound to the compressions in order to facilitate correct placement as well. Due to timing constraints, we weren't able to simulate a torso or hands in the AR environment. So we purchased a 2-inch thick foam that a person could use in real life to gauge compression placement and how deep their compressions should be. But we were able to embed audio with slides that provide compression information so that the user has cues for the correct pacing while performing compressions. 

Figma Slide Link: https://www.figma.com/proto/VLd5kKy1kRDH1e0Px1JBTZ/IKEP_Figma-Toolkit-for-MRTK-%2F-HoloLens?node-id=11025%3A1685&scaling=contain&page-id=11025%3A1684

#### How to use the AR CPR Guide
Simply, the user will need to wear their HoloLens, open the guide, and use the 'Proceed' button to click through the guide.

#### Immersion and Interaction
The Hololens assists in providing both immersion and interactivity. By wearing the HoloLens, the user experiences a mixed reality immersion because they are visually being placed in a computer-generated environment that is augmented on their real-world view. There is audio immersion because the user hears a sound that correlates to the correct pacing of compressions. Also, there is a level of immersion from having the foam available to practice compressions with. Since the foam is 2 inches thick, a full compression of the foam is equivalent to the depth of compression that is needed on a human body.

The HoloLens adds to the interactivity because the user can make gestures in the real world that are recognized and applied to the virtual environment. While using the CPR guide, the user uses a selection technique to press through the slide. Specifically, the user uses the air tap gesture to press a button, which incorporates a collider to recognize the user's air tap. The button has varying light functions offering signals to the user. For example, hovering over the button highlights the button to signal that the user's finger is correctly over the button. When the user taps the button, the button light fades out a bit to show that the button has been pressed then returns to its original lighting after the release of the button press.

#### Testing Experience
