include("${CMAKE_CURRENT_LIST_DIR}/rule.cmake")
include("${CMAKE_CURRENT_LIST_DIR}/file.cmake")
set(ADC_default_library_list )
# Handle files with suffix (s|as|asm|AS|ASM|As|aS|Asm) 
if(ADC_default_FILE_GROUP_assemble)
    add_library(ADC_default_assemble OBJECT ${ADC_default_FILE_GROUP_assemble})
    ADC_default_assemble_rule(ADC_default_assemble)
    list(APPEND ADC_default_library_list "$<TARGET_OBJECTS:ADC_default_assemble>")
endif()

# Handle files with suffix S 
if(ADC_default_FILE_GROUP_assemblePreprocess)
    add_library(ADC_default_assemblePreprocess OBJECT ${ADC_default_FILE_GROUP_assemblePreprocess})
    ADC_default_assemblePreprocess_rule(ADC_default_assemblePreprocess)
    list(APPEND ADC_default_library_list "$<TARGET_OBJECTS:ADC_default_assemblePreprocess>")
endif()

# Handle files with suffix [cC] 
if(ADC_default_FILE_GROUP_compile)
    add_library(ADC_default_compile OBJECT ${ADC_default_FILE_GROUP_compile})
    ADC_default_compile_rule(ADC_default_compile)
    list(APPEND ADC_default_library_list "$<TARGET_OBJECTS:ADC_default_compile>")
endif()

if (BUILD_LIBRARY)
        message(STATUS "Building LIBRARY")
        add_library(${ADC_default_image_name} ${ADC_default_library_list})
        foreach(lib ${ADC_default_FILE_GROUP_link})
        target_link_libraries(${ADC_default_image_name} PRIVATE ${CMAKE_CURRENT_LIST_DIR} /${lib})
        endforeach()
        add_custom_command(
            TARGET ${ADC_default_image_name}
    COMMAND ${CMAKE_COMMAND} -E make_directory ${ADC_default_output_dir}
    COMMAND ${CMAKE_COMMAND} -E copy lib${ADC_default_image_name}.a ${ADC_default_output_dir}/${ADC_default_original_image_name})
else()
    message(STATUS "Building STANDARD")
    add_executable(${ADC_default_image_name} ${ADC_default_library_list})
    foreach(lib ${ADC_default_FILE_GROUP_link})
    target_link_libraries(${ADC_default_image_name} PRIVATE ${CMAKE_CURRENT_LIST_DIR}/${lib})
endforeach()
    ADC_default_link_rule(${ADC_default_image_name})
    
add_custom_command(
    TARGET ${ADC_default_image_name}
    COMMAND ${CMAKE_COMMAND} -E make_directory ${ADC_default_output_dir}
    COMMAND ${CMAKE_COMMAND} -E copy ${ADC_default_image_name} ${ADC_default_output_dir}/${ADC_default_original_image_name})
endif()
