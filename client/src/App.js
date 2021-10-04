import { useState } from 'react'
import './App.css';
import { Movies } from './components/Movies/Movies';
import {Header} from './components/Header/Header'
import { SearchContainer } from './components/SearchContainer/SearchContainer';
import {getMovies} from './redux/actions/movie'

function App() {
  const [searchValue, setSearchValue] = useState("")

    const onChange = (e) => {
        setSearchValue(e.target.value)
    }
  return (
    <div className="App">
      <Header />
      <SearchContainer
        value={searchValue}
        name="searchValue"
        handleChange={onChange}
        searchAction={getMovies}
      />
      <Movies />
    </div>
  );
}

export default App;
