### Project 4: VR/AR for Social Good!
### Isha Kanu and Esther Putman
ATLS-CSCI 5616-001
December 11, 2021
#### Unity Version: 2019.4.33f1

## Project Title: AR CPR Guide

### Project Theme Description

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


### Theme and Storyboard Development

When we decided to create an AR application to assist in performing CPR, we immediately thought about creating a CPR guide. We wanted the guide to be used when a person was in a situation invoking the use of CPR. We imagined that the person would already be CPR certified, so they would be using this guide as a way to be reminded of steps in case they were a bit nervous or apprehensive. As a result, the interface was designed to be super simplistic and easy to go through so that time is spent focused on the situation. The slides were developed in Figma (link below). We also thought that it would be nice to add some sort of simulation of the torso and/or human hands within the AR environment so that the user could gauge where to place their hands on a human body and the correct pacing of the compressions. We wanted to tie in sound to the compressions in order to facilitate correct placement as well. Due to timing constraints, we weren't able to simulate a torso or hands in the AR environment. So we purchased a 2-inch thick foam that a person could use in real life to gauge compression placement and how deep their compressions should be. But we were able to embed audio with slides that provide compression information so that the user has cues for the correct pacing while performing compressions. 

Figma Slides can be found [here](https://www.figma.com/proto/VLd5kKy1kRDH1e0Px1JBTZ/IKEP_Figma-Toolkit-for-MRTK-%2F-HoloLens?node-id=11025%3A1685&scaling=contain&page-id=11025%3A1684)

### How to use the AR CPR Guide

Simply, the user will need to wear their HoloLens, open the guide, and use the 'Proceed' button to click through the guide. 
Pressing the button can be done by using your gaze to bring the cursor over the button. When your finger is raised, the button will be selected (as indicated by the hover light). When you want to press the button, you can bend your finger forward (as if trying to tap the button) to click. 
When the user reaches instructions that require compressions, audio guiding the ideal rate (100 BPM) will play. 

### Immersion and Interaction

The Hololens assists in providing both immersion and interactivity. By wearing the HoloLens, the user experiences a mixed reality immersion because they are visually being placed in a computer-generated environment that is augmented on their real-world view. There is audio immersion because the user hears a sound that correlates to the correct pacing of compressions. Also, there is a level of immersion from having the foam available to practice compressions with. Since the foam is 2 inches thick, a full compression of the foam is equivalent to the depth of compression that is needed on a human body.

The HoloLens adds to the interactivity because the user can make gestures in the real world that are recognized and applied to the virtual environment. While using the CPR guide, the user uses a selection technique to press through the slide. Specifically, the user uses the air tap gesture to press a button, which incorporates a collider to recognize the user's air tap. The button has varying light functions offering signals to the user. For example, hovering over the button highlights the button to signal that the user's finger is correctly over the button. When the user taps the button, the button light fades out a bit to show that the button has been pressed then returns to its original lighting after the release of the button press.

Interactions in HoloLens can be very difficult to develop. In order to make them work, we had to carefully define our coordinates, plane distances, and camera clipping planes to make a comfortable experience. MRTK came with prefab buttons that had suggested plane distances for push interactions, which helped us guide the scale of other objects in our experience. We designed the instructions to proceed with a button press. Audio guiding the desired rate of compressions starts when instructions require compressions, and stops when transitioning out of those steps. 

The next challenge came with wanting the instructions to appear similar to a heads up display, where they were always in view regardless of gaze. This was important for integrating the instructions into the experience of learning CPR, rather than requiring a change in head position that might distract from the task. At first, we tried to implement this using a canvas with a camera screen space overlay. While this provided a stable placement of instructions in the user’s field of view, they no longer registered interactions. This is due to how a screen space overlay canvas works by creating a 2D perspective. We then switched to a solver system, which updates the position of an object using information from a tracked object. HoloLens provides head tracking, which we used to make sure that the CPR instructions remained within a radial cone of view projected from the tracked head. If the user moves their gaze beyond that cone, the instructions will follow to remain in sight. 


### Testing Experience

During our demonstration, many of the users who tested our experience gave positive feedback about the instuctions for CPR being clear and easy to read. However, some had troubles interacting with HoloLens. A large part of this was unfamiliarity with the gestures needed to make it work. Realizing this, our CPR trainer may be based used during CPR certification courses where designated time could be given to getting familiar with HoloLens. It could also be used for training alongside additional rendering of environments that replicate the stress of emergency situations like a car crash. Audio and visual elements could be used to increase anxiety and a sense of urgency which reflect the reality of performing CPR in true emergent scenarios. We also found that some users struggled to see the full instructions during use, which was often a problem with how the HoloLens was worn. The best tracking happened with a tight head fit, and the rendering distances were best when the users centered the holographic glass with their natural gaze, which could be a confusing adjustment direction to receive for a novel user. Finally, we received feedback about the amount of information on the instruction slides. This could be simplified to only provide basic prompts, or the slides with heavy text could be broken into two separate instructions. We could also alleviate the text burden by using more audio cues for instructions. 
