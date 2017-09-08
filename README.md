# Web RTC Native for Xamarin
A Xamarin Android Java Bindings project for native WebRTC.

Use this project to generate a C# DLL of the [Android native WebRTC library](webrtc.org/native-code/android/), for use with Xamarin Android applications.

By default, the native library images included in your AAR will be baked into the DLL that's emitted from this process.

## Usage

1. Add `libwebrtc.aar` to `libwebrtc/Jars/`. </p> You can build it yourself, or download a pre-built version. To build it, use `tools-webrtc/android/build_aar.py`. See [this link](https://github.com/RestComm/restcomm-android-sdk/wiki/How-to-build-webrtc-library-for-Android-in-OSX-host) as well as the above link for more details.

2. Build the project. <p> The resulting `libwebrtc.dll` will appear in the build outputs directory.
