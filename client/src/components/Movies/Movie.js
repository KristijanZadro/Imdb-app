import React from 'react'
import './Movies.css'

export const Movie = ({movie}) => {
    return (
        <div className="movieCard">
            <h3>{movie.title}</h3>
            <p>{movie.desctiption}</p>
            <p>{movie.averageRating}</p>
        </div>
    )
}
