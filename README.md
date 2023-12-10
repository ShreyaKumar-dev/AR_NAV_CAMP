# AR_NAV_CAMP
Augmented Reality (AR) based Indoor Navigation Application
<br><br>
AR NAV CAMP project is motivated to build from the growing need for efficient indoor navigation solutions.
<br>
Traditional navigation apps are predominantly designed for outdoor use and are often ineffective within the confines of buildings. This limitation has led to frustration and time wastage for users trying to find specific locations indoors. Our project aims to address this issue and offer a more intuitive and user-friendly solution for indoor navigation.
<br>

<h2>Problem Statement</h2>
To tackle the lack of accurate and user-friendly indoor navigation tools.
<br>

<h2>Objective</h2>
1. Develop an AR-based indoor navigation system that can accurately guide users to their desired destinations within complex indoor environments.<br>
2. Create a user interface that is easy to understand and accessible.
3. Implement real-time positioning and mapping technology to provide up-to-date navigation instructions.
<br>

<h2>Architechture of the application</h2>
<h3>1. Hardware Components:</h3>
<b>1.1 User device:</b> To run application <br>
<b>1.2 Sensors:</b> Camera (captures user’s movements, orientations, and visual data for precise indoor positioning and AR overlays.)
<br><br>
<h3>2. Software Components:</h3>
<b>2.1 Operating System:</b> Android or IOS <br>
<b>2.2 AR Development Framework:</b> Unity, ARKit, or ARCore (These frameworks enable marker tracking, object recognition, and 3D rendering.)
<br><br>
<h3>3. Navigation Algorithm and Framework:</h3>
<b>3.1 Navigation System:</b> It employs advanced navigation algorithms to calculate optimal routes, handle pathfinding, and provide real-time instructions. It retraces the user's location, destination, and surrounding environment. <br>
<b>3.2 Positioning System:</b> The positioning system uses a device camera to determine the user's location accurately.
<br><br>
<h3>4. User Interface Framework:</h3>
<b>4.1 UI Components:</b> Components include maps, dropdown menu, and turn-by-turn instructions. <br>
<b>4.2 Design Principles:</b> The UI design adheres to user experience (UX) and user interface (UI) design principles, ensuring that information is presented clearly and accessible.
<br><br>
<h3>5. Integration and Compatibility:</h3>
<b>5.1 Device Compatibility:</b> The application is designed to be compatible with a range of user devices (smartphones and tablets). It adapts to different screen sizes and capabilities. <br>
<b>5.2 Operating System Compatibility:</b> The AR Indoor Navigation system of the AR NAV CAMP application seamlessly integrates with iOS and Android operating systems, optimizing performance and feature availability for each.
<br>

<h2>Process Design</h2>
<img src="./images/Process_Design.png" width="600px" height="400px">

<h2>Algorithm Used</h2>
<b>1. NavMesh tools</b> to generate a walkable surface map of the campus environment. Defined regions accessible to users, considering obstacles, buildings, and restricted areas.
<br><br>
<b>2. A* Algorithm</b> to calculate shortest path.

<h2>Design</h2>
<img src="./images/stage 1.png" height="300px">
<p>Stage 1: Start of App</p> <br>
<img src="./images/stage 2.png" height="300px">
<p>Stage 2: Homepage</p> <br>
<img src="./images/stage 3.png" height="300px">
<p>Stage 3: Bracode Scanner</p> <br>
<img src="./images/stage 4.png" height="300px">
<p>Stage 4: Loading Animation</p> <br>
<img src="./images/stage 5.png" height="300px">
<p>Stage 5: Destination Selection using Drop-Down Box</p> <br>
<img src="./images/stage 6.png" height="300px">
<p>Stage 6: Rendering Guidline</p>