# Toast and Snackbar Project for Unity Android

This Unity project demonstrates the implementation of toast messages and snackbars for the Android platform. Toast messages and snackbars are commonly used UI elements to display short notifications to the user.

## Getting Started

### Installation

1. Clone or download this repository to your local machine.

2. Open Unity and select "Open Project." Navigate to the downloaded project folder and select the project.

3. Once the project is loaded, you can explore the existing scene and scripts for implementing toast messages and snackbars.

## Usage

### Adding Toasts

1. Create a UI button in the scene and attach the `ShowToast` method from the `ToastManager` script to its onClick event in the Unity Inspector.

2. Assign the `ToastPrefab` and `ToastParent` fields of the `ToastManager` script by dragging and dropping the appropriate GameObjects in the Unity Inspector.

3. Adjust the appearance and content of the toast prefab in the Unity scene by customizing the UI Text component.

4. Play the scene and click the button to see a toast message displayed for a specified duration.

### Adding Snackbars

1. Similar to adding toasts, create a UI button and attach the `ShowSnackbar` method from the `SnackbarManager` script to its onClick event.

2. Assign the `SnackbarPrefab` and `SnackbarParent` fields of the `SnackbarManager` script.

3. Customize the appearance and content of the snackbar prefab as needed.

4. Play the scene and click the button to show a snackbar notification.

## Customization

You can customize the appearance and behavior of toast messages and snackbars by modifying the prefab GameObjects, adjusting the scripts, and implementing additional features.

