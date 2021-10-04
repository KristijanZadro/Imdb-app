import { useEffect, useRef, useState } from 'react'
//import './SearchContainer.css'
//import { AiOutlineSearch } from 'react-icons/ai'
import { useDispatch } from 'react-redux'
import _ from 'lodash'
//import { useSearchContainerStyles } from '../../materialStyles/SearchContainerStyle'
import InputBase from '@material-ui/core/InputBase';
//import SearchIcon from '@material-ui/icons/Search';

export const SearchContainer = ({ value, name, handleChange, searchAction }) => {
    const dispatch = useDispatch()

    //const classes = useSearchContainerStyles();

    const isInitialMount = useRef(true)

    const [errorMsg, setErrorMsg] = useState()

    useEffect(() => {
        if (isInitialMount.current) {
            isInitialMount.current = false
        } else {
            if (!_.isEmpty(value) && value.trim().length >= 2) {
                setErrorMsg()
                const timer = setTimeout(() => {
                    dispatch(searchAction(value))
                }, 1000)
                return () => clearTimeout(timer);
            } else if (_.isEmpty(value)) {
                setErrorMsg()
                dispatch(searchAction(value))
            } else if (!value.trim()) {
                setErrorMsg("Search should not contain only empty space!")
            } else if (value.trim().length < 2) {
                setErrorMsg("Search must contain more than two characters!")
            }
        }
    }, [dispatch, value, searchAction])

    return (
        <div className="searchContainer">
            <div className="searchBox">
                <div>
                    <div
                        onClick={() => dispatch(searchAction(value))}
                    >
                        search
                    </div>
                    <InputBase
                        type="text"
                        value={value || ''}
                        name={name}
                        onChange={handleChange}
                        placeholder="Search…"
                        inputProps={{ 'aria-label': 'search' }}
                    />
                </div>
                <div className="errorMsg">
                    <p>{errorMsg}</p>
                </div>
            </div>
        </div>
    )
}
