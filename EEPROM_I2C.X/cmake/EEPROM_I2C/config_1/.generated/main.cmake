include("${CMAKE_CURRENT_LIST_DIR}/rule.cmake")
include("${CMAKE_CURRENT_LIST_DIR}/file.cmake")
set(EEPROM_I2C_config_1_library_list )
# Handle files with suffix (s|as|asm|AS|ASM|As|aS|Asm) 
if(EEPROM_I2C_config_1_FILE_GROUP_assemble)
    add_library(EEPROM_I2C_config_1_assemble OBJECT ${EEPROM_I2C_config_1_FILE_GROUP_assemble})
    EEPROM_I2C_config_1_assemble_rule(EEPROM_I2C_config_1_assemble)
    list(APPEND EEPROM_I2C_config_1_library_list "$<TARGET_OBJECTS:EEPROM_I2C_config_1_assemble>")
endif()

# Handle files with suffix S 
if(EEPROM_I2C_config_1_FILE_GROUP_assemblePreprocess)
    add_library(EEPROM_I2C_config_1_assemblePreprocess OBJECT ${EEPROM_I2C_config_1_FILE_GROUP_assemblePreprocess})
    EEPROM_I2C_config_1_assemblePreprocess_rule(EEPROM_I2C_config_1_assemblePreprocess)
    list(APPEND EEPROM_I2C_config_1_library_list "$<TARGET_OBJECTS:EEPROM_I2C_config_1_assemblePreprocess>")
endif()

# Handle files with suffix [cC] 
if(EEPROM_I2C_config_1_FILE_GROUP_compile)
    add_library(EEPROM_I2C_config_1_compile OBJECT ${EEPROM_I2C_config_1_FILE_GROUP_compile})
    EEPROM_I2C_config_1_compile_rule(EEPROM_I2C_config_1_compile)
    list(APPEND EEPROM_I2C_config_1_library_list "$<TARGET_OBJECTS:EEPROM_I2C_config_1_compile>")
endif()

if (BUILD_LIBRARY)
        message(STATUS "Building LIBRARY")
        add_library(${EEPROM_I2C_config_1_image_name} ${EEPROM_I2C_config_1_library_list})
        foreach(lib ${EEPROM_I2C_config_1_FILE_GROUP_link})
        target_link_libraries(${EEPROM_I2C_config_1_image_name} PRIVATE ${CMAKE_CURRENT_LIST_DIR} /${lib})
        endforeach()
        add_custom_command(
            TARGET ${EEPROM_I2C_config_1_image_name}
    COMMAND ${CMAKE_COMMAND} -E make_directory ${EEPROM_I2C_config_1_output_dir}
    COMMAND ${CMAKE_COMMAND} -E copy lib${EEPROM_I2C_config_1_image_name}.a ${EEPROM_I2C_config_1_output_dir}/${EEPROM_I2C_config_1_original_image_name})
else()
    message(STATUS "Building STANDARD")
    add_executable(${EEPROM_I2C_config_1_image_name} ${EEPROM_I2C_config_1_library_list})
    foreach(lib ${EEPROM_I2C_config_1_FILE_GROUP_link})
    target_link_libraries(${EEPROM_I2C_config_1_image_name} PRIVATE ${CMAKE_CURRENT_LIST_DIR}/${lib})
endforeach()
    EEPROM_I2C_config_1_link_rule(${EEPROM_I2C_config_1_image_name})
    
add_custom_command(
    TARGET ${EEPROM_I2C_config_1_image_name}
    COMMAND ${CMAKE_COMMAND} -E make_directory ${EEPROM_I2C_config_1_output_dir}
    COMMAND ${CMAKE_COMMAND} -E copy ${EEPROM_I2C_config_1_image_name} ${EEPROM_I2C_config_1_output_dir}/${EEPROM_I2C_config_1_original_image_name})
endif()
