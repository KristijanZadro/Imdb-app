import React from 'react'
import {Button as MaterialButton} from '@mui/material'

export const Button = ({text, icon, clickAction}) => {
    return (
        <MaterialButton
            type="submit"
            variant="contained"
            onClick={clickAction}
        >
            <span>{icon}</span>
            <span>{text}</span>
        </MaterialButton>
    )
}

Button.defaultProps = {
    type: "submit"
}