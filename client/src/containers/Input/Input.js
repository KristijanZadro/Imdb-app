import React from 'react'
import TextField from '@mui/material/TextField';

export const Input = ({value, name, label, handleChange}) => {
    return (
        <TextField
            id="outlined-name"
            size="small"
            label={label}
            value={value}
            name={name}
            onChange={handleChange}
        />
    )
}
