

<h1 align="center">
   <img src="Logo/vultaik-logo.png" width=410>

  
  ##               Vultaik is a 2D/3D toy engine implemented in [Vulkan®]([https://www.khronos.org/vulkan/](https://learn.microsoft.com/en-us/windows/win32/direct3d12/directx-12-programming-guide))
  
</h1>


  ##              



## Overview
This toy engine is designed for the Vulkan learning process, I mainly use it to experiment with graphical or computing techniques and should not be used as a cerium product as it may have memory leaks and faulty or poorly optimized implementations.

## Low-level rendering backend
The rendering backend focuses entirely on Vulkan, so it reuses Vulkan enums and data structures where appropriate. However, the API greatly simplifies the more painful points of writing straight Vulkan. It's not designed to be the fastest renderer ever made, it's likely a happy middle ground between "perfect" Vulkan and OpenGL/D3D11 w.r.t. CPU overhead.



## Examples


Example | Details
---------|--------
<img src="Src/Screenshots/ClearScreen.PNG" width=380> | [Clear Screen](Src/Samples/Samples/ClearScreen/ClearScreen.cs)<br> This example shows how to configure the device and clear the color.
<img src="Src/Screenshots/Triangle.PNG" width=380> | [Triangle](Src/Samples/Samples/Triangle/Triangle.cs)<br> This example shows how to render simple triangle.
<img src="Src/Screenshots/Transformations.PNG" width=380> | [Transformations](Src/Samples/Samples/Transformations/Transformations.cs)<br> This example how to transform the world space for each object.
<img src="Src/Screenshots/PushConstant.PNG" width=380> | [Push Constant](Src/Samples/Samples/PushConstant/PushConstant.cs)<br> This example use push constants, small blocks of uniform data stored within a command buffer, to pass data to a shader without the need for uniform buffers.
<img src="Src/Screenshots/LoadGLTF.PNG" width=380> | [Load GLTF](Src/Samples/Samples/LoadGLTF/LoadGLTF.cs)<br> This example shows how to load GLTF models.
<img src="Src/Screenshots/LoadTexture.PNG" width=380> | [Load Texture](Src/Samples/Samples/LoadTexture/LoadTexture.cs)<br> This example shows how to load 2D texture from disk (including all mip levels). 
<img src="Src/Screenshots/Bindless.PNG" width=380> | [Bindless](Src/Samples/Samples/Bindless/Bindless.cs)<br> This example demonstrates the use of VK_EXT_descriptor_indexing for creating descriptor sets with a variable size that can be dynamically indexed in a shader using `SPV_EXT_descriptor_indexing`.
<img src="Src/Screenshots/DiffuseLighting.PNG" width=380> | [Diffuse Lighting](Src/Samples/Samples/Lighting/Lighting.cs)<br> This example shows how to create diffuse lighting. 
<img src="Src/Screenshots/AmbientLighting.PNG" width=380> | [Ambient Lighting](Src/Samples/Samples/AmbientLighting/AmbientLighting.cs)<br> This example shows how to create ambient lighting. 
<img src="Src/Screenshots/SpecularLighting.PNG" width=380> | [Specular Lighting](Src/Samples/Samples/SpecularLighting/SpecularLighting.cs)<br> This example shows how to create specular lighting. 
<img src="Src/Screenshots/ComputeTexture.PNG" width=380> | [Compute Texture](Src/Samples/Samples/SpecularLighting/ComputeTexture.cs)<br> Use a calculation shader in conjunction with a separate calculation queue to modify a full screen image.
<hr>
<br>




[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://github.com/FaberSanZ/Vultaik/blob/master/LICENSE) 

The code is licensed under MIT. Feel free to use it for whatever purpose.
