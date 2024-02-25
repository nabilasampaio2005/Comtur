import React from "react";
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import Noticia from './screens/noticia/noticia';
import VisualizarNoticia from './screens/noticia/visualizarNoticia';
import Home from "./screens/home";
import TipoTurismo from "./screens/tipoturismo";
import TipoAtracao from "./screens/tipoatracao";
import Inicio from "./screens/inicio/inicio";
import Empresario from "./screens/empresario/empresario";
import Administrador from "./screens/administrador/administrador";
import TipoUsuario from "./screens/tipousuario/tipousuario";

const AppRoutes = () => {
    return (
        <Router>
            <Routes>
                <Route path="/inicio" element={ <Inicio />} />
                <Route path="/home"  element={ <Home />} />
                <Route path="/noticia" element={ <Noticia /> } />
                <Route path="/tipoturismo" element={ <TipoTurismo/> }/>
                <Route path="/tipoatracao" element={ <TipoAtracao/> }/>
                <Route path="/empresario" element={ <Empresario/>} />
                <Route path="/visualizarNoticia/:id" element={ <VisualizarNoticia/>} />
                <Route path="/administrador" element={<Administrador/>} />
                <Route path="/tipousuario" element={<TipoUsuario/>} />
            </Routes>
        </Router>
    );
}

export default AppRoutes;