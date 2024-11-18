include("${CMAKE_CURRENT_LIST_DIR}/rule.cmake")
include("${CMAKE_CURRENT_LIST_DIR}/file.cmake")
set(DigitalPorts_default_library_list )
# Handle files with suffix (s|as|asm|AS|ASM|As|aS|Asm) 
if(DigitalPorts_default_FILE_GROUP_assemble)
    add_library(DigitalPorts_default_assemble OBJECT ${DigitalPorts_default_FILE_GROUP_assemble})
    DigitalPorts_default_assemble_rule(DigitalPorts_default_assemble)
    list(APPEND DigitalPorts_default_library_list "$<TARGET_OBJECTS:DigitalPorts_default_assemble>")
endif()

# Handle files with suffix S 
if(DigitalPorts_default_FILE_GROUP_assemblePreprocess)
    add_library(DigitalPorts_default_assemblePreprocess OBJECT ${DigitalPorts_default_FILE_GROUP_assemblePreprocess})
    DigitalPorts_default_assemblePreprocess_rule(DigitalPorts_default_assemblePreprocess)
    list(APPEND DigitalPorts_default_library_list "$<TARGET_OBJECTS:DigitalPorts_default_assemblePreprocess>")
endif()

# Handle files with suffix [cC] 
if(DigitalPorts_default_FILE_GROUP_compile)
    add_library(DigitalPorts_default_compile OBJECT ${DigitalPorts_default_FILE_GROUP_compile})
    DigitalPorts_default_compile_rule(DigitalPorts_default_compile)
    list(APPEND DigitalPorts_default_library_list "$<TARGET_OBJECTS:DigitalPorts_default_compile>")
endif()

if (BUILD_LIBRARY)
        message(STATUS "Building LIBRARY")
        add_library(${DigitalPorts_default_image_name} ${DigitalPorts_default_library_list})
        foreach(lib ${DigitalPorts_default_FILE_GROUP_link})
        target_link_libraries(${DigitalPorts_default_image_name} PRIVATE ${CMAKE_CURRENT_LIST_DIR} /${lib})
        endforeach()
        add_custom_command(
            TARGET ${DigitalPorts_default_image_name}
    COMMAND ${CMAKE_COMMAND} -E make_directory ${DigitalPorts_default_output_dir}
    COMMAND ${CMAKE_COMMAND} -E copy lib${DigitalPorts_default_image_name}.a ${DigitalPorts_default_output_dir}/${DigitalPorts_default_original_image_name})
else()
    message(STATUS "Building STANDARD")
    add_executable(${DigitalPorts_default_image_name} ${DigitalPorts_default_library_list})
    foreach(lib ${DigitalPorts_default_FILE_GROUP_link})
    target_link_libraries(${DigitalPorts_default_image_name} PRIVATE ${CMAKE_CURRENT_LIST_DIR}/${lib})
endforeach()
    DigitalPorts_default_link_rule(${DigitalPorts_default_image_name})
    
add_custom_command(
    TARGET ${DigitalPorts_default_image_name}
    COMMAND ${CMAKE_COMMAND} -E make_directory ${DigitalPorts_default_output_dir}
    COMMAND ${CMAKE_COMMAND} -E copy ${DigitalPorts_default_image_name} ${DigitalPorts_default_output_dir}/${DigitalPorts_default_original_image_name})
endif()
