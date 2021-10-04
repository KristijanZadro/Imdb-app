import { useEffect } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import { getMovies } from '../../redux/actions/movie'
import { Movie } from './Movie'

export const Movies = () => {
    const dispatch = useDispatch()
    const movies = useSelector(state => state.movies.movies)
    useEffect(() => {
        dispatch(getMovies())
    }, [dispatch])

    const moviesRender = movies.map(movie => {
        return (
            <div key={movie.id}>
                <Movie
                    movie={movie}
                />
            </div>

        )
    })
    return (
        <div className="moviesContainer">
            {moviesRender}
        </div>
    )
}
