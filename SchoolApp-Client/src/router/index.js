import Vue from 'vue'
import Router from 'vue-router'
import home from '@/components/home'
import Curso from '@/components/Curso'
import Materia from '@/components/Materia'
import Estudiante from '@/components/Estudiante'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/home',
      name: 'home',
      component: home
    },
    {
      path: '/Curso',
      name: 'Curso',
      component: Curso
    },
    {
      path: '/Materia',
      name: 'Materia',
      component: Materia
    },
    {
      path: '/Estudiante',
      name: 'Estudiante',
      component: Estudiante
    }
  ]
})
