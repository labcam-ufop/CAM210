include("${CMAKE_CURRENT_LIST_DIR}/rule.cmake")
include("${CMAKE_CURRENT_LIST_DIR}/file.cmake")
set(7segm_default_library_list )
# Handle files with suffix (s|as|asm|AS|ASM|As|aS|Asm) 
if(7segm_default_FILE_GROUP_assemble)
    add_library(A_7segm_default_assemble OBJECT ${7segm_default_FILE_GROUP_assemble})
    A_7segm_default_assemble_rule(A_7segm_default_assemble)
    list(APPEND 7segm_default_library_list "$<TARGET_OBJECTS:A_7segm_default_assemble>")
endif()

# Handle files with suffix S 
if(7segm_default_FILE_GROUP_assemblePreprocess)
    add_library(A_7segm_default_assemblePreprocess OBJECT ${7segm_default_FILE_GROUP_assemblePreprocess})
    A_7segm_default_assemblePreprocess_rule(A_7segm_default_assemblePreprocess)
    list(APPEND 7segm_default_library_list "$<TARGET_OBJECTS:A_7segm_default_assemblePreprocess>")
endif()

# Handle files with suffix [cC] 
if(7segm_default_FILE_GROUP_compile)
    add_library(A_7segm_default_compile OBJECT ${7segm_default_FILE_GROUP_compile})
    A_7segm_default_compile_rule(A_7segm_default_compile)
    list(APPEND 7segm_default_library_list "$<TARGET_OBJECTS:A_7segm_default_compile>")
endif()

if (BUILD_LIBRARY)
        message(STATUS "Building LIBRARY")
        add_library(${7segm_default_image_name} ${7segm_default_library_list})
        foreach(lib ${7segm_default_FILE_GROUP_link})
        target_link_libraries(${7segm_default_image_name} PRIVATE ${CMAKE_CURRENT_LIST_DIR} /${lib})
        endforeach()
        add_custom_command(
            TARGET ${7segm_default_image_name}
    COMMAND ${CMAKE_COMMAND} -E make_directory ${7segm_default_output_dir}
    COMMAND ${CMAKE_COMMAND} -E copy lib${7segm_default_image_name}.a ${7segm_default_output_dir}/${7segm_default_original_image_name})
else()
    message(STATUS "Building STANDARD")
    add_executable(${7segm_default_image_name} ${7segm_default_library_list})
    foreach(lib ${7segm_default_FILE_GROUP_link})
    target_link_libraries(${7segm_default_image_name} PRIVATE ${CMAKE_CURRENT_LIST_DIR}/${lib})
endforeach()
    A_7segm_default_link_rule(${7segm_default_image_name})
    
add_custom_command(
    TARGET ${7segm_default_image_name}
    COMMAND ${CMAKE_COMMAND} -E make_directory ${7segm_default_output_dir}
    COMMAND ${CMAKE_COMMAND} -E copy ${7segm_default_image_name} ${7segm_default_output_dir}/${7segm_default_original_image_name})
endif()
