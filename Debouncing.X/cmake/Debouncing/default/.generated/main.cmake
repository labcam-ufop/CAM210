include("${CMAKE_CURRENT_LIST_DIR}/rule.cmake")
include("${CMAKE_CURRENT_LIST_DIR}/file.cmake")
set(Debouncing_default_library_list )
# Handle files with suffix (s|as|asm|AS|ASM|As|aS|Asm) 
if(Debouncing_default_FILE_GROUP_assemble)
    add_library(Debouncing_default_assemble OBJECT ${Debouncing_default_FILE_GROUP_assemble})
    Debouncing_default_assemble_rule(Debouncing_default_assemble)
    list(APPEND Debouncing_default_library_list "$<TARGET_OBJECTS:Debouncing_default_assemble>")
endif()

# Handle files with suffix S 
if(Debouncing_default_FILE_GROUP_assemblePreprocess)
    add_library(Debouncing_default_assemblePreprocess OBJECT ${Debouncing_default_FILE_GROUP_assemblePreprocess})
    Debouncing_default_assemblePreprocess_rule(Debouncing_default_assemblePreprocess)
    list(APPEND Debouncing_default_library_list "$<TARGET_OBJECTS:Debouncing_default_assemblePreprocess>")
endif()

# Handle files with suffix [cC] 
if(Debouncing_default_FILE_GROUP_compile)
    add_library(Debouncing_default_compile OBJECT ${Debouncing_default_FILE_GROUP_compile})
    Debouncing_default_compile_rule(Debouncing_default_compile)
    list(APPEND Debouncing_default_library_list "$<TARGET_OBJECTS:Debouncing_default_compile>")
endif()

if (BUILD_LIBRARY)
        message(STATUS "Building LIBRARY")
        add_library(${Debouncing_default_image_name} ${Debouncing_default_library_list})
        foreach(lib ${Debouncing_default_FILE_GROUP_link})
        target_link_libraries(${Debouncing_default_image_name} PRIVATE ${CMAKE_CURRENT_LIST_DIR} /${lib})
        endforeach()
        add_custom_command(
            TARGET ${Debouncing_default_image_name}
    COMMAND ${CMAKE_COMMAND} -E make_directory ${Debouncing_default_output_dir}
    COMMAND ${CMAKE_COMMAND} -E copy lib${Debouncing_default_image_name}.a ${Debouncing_default_output_dir}/${Debouncing_default_original_image_name})
else()
    message(STATUS "Building STANDARD")
    add_executable(${Debouncing_default_image_name} ${Debouncing_default_library_list})
    foreach(lib ${Debouncing_default_FILE_GROUP_link})
    target_link_libraries(${Debouncing_default_image_name} PRIVATE ${CMAKE_CURRENT_LIST_DIR}/${lib})
endforeach()
    Debouncing_default_link_rule(${Debouncing_default_image_name})
    
add_custom_command(
    TARGET ${Debouncing_default_image_name}
    COMMAND ${CMAKE_COMMAND} -E make_directory ${Debouncing_default_output_dir}
    COMMAND ${CMAKE_COMMAND} -E copy ${Debouncing_default_image_name} ${Debouncing_default_output_dir}/${Debouncing_default_original_image_name})
endif()
